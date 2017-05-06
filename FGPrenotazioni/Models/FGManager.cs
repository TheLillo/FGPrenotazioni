using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models.Riepilogues;
using FGPrenotazioni.Models.Invoices;
using FGPrenotazioni.Models.GoodsMovements;
using System.Windows.Forms;
using FGPrenotazioni.Models.Products;
using System.Globalization;
using FGPrenotazioni.Models.Persistence;
using System.Collections.Specialized;
using System.IO;

namespace FGPrenotazioni.Models
{
    public class FGManager
    {
        private static FGManager _instance;
        public static CultureInfo CultureInfo { get; set; } = new CultureInfo("it-IT");

        private Warehouse _warehouse;
        private Employee _logged = null;
        private ShoppingCart _shoppingCart;

        public static FGManager Instance
        {
            get { return _instance ?? (_instance = new FGManager()); }
        }

        private FGManager()
        {
            _warehouse = new Warehouse();

            _shoppingCart = new ShoppingCart();

            _costumerRiepilogue = new CustomerRiepilogue();
            _rentsRiepilogue = new RentRiepilogue();
            _invoicesRiepilogue = new InvoicesRiepilogue();
            _products = new List<Product>();
            CheckFiles();
            _products = XmlSerializerUtil.Load<List<Product>>("prodotti.xml");
            foreach (Product p in _products)
            {
                _warehouse.AddProduct(p);
            }

            _costumerRiepilogue.AddAll(DatBinaryFormatter.Load<List<Customer>>("riepiloghiCustomer.dat"));

            _rentsRiepilogue.AddAll(DatBinaryFormatter.Load<List<Rent>>("riepiloghiRent.dat"));

            _invoicesRiepilogue.AddAll(DatBinaryFormatter.Load<List<Invoice>>("riepiloghiInvoice.dat"));

            _invoicesRiepilogue.GetAll.CollectionChanged += onInvoiceRiepilogue;
            _costumerRiepilogue.GetAll.CollectionChanged += onCustomerRiepilogue;
            _rentsRiepilogue.GetAll.CollectionChanged += onRentsRiepilogue;
            _warehouse.ProductList.CollectionChanged += onWarehouse;

        }

        private void CheckFiles()
        {
            if (!File.Exists("prodotti.xml"))
            {
                XmlSerializerUtil.Save<List<Product>>("prodotti.xml", _warehouse.ProductList.ToList());
            }
            if (!File.Exists("riepiloghiCustomer.dat"))
            {
                DatBinaryFormatter.Save<List<Customer>>("riepiloghiCustomer.dat", _costumerRiepilogue.GetAll.ToList());
            }
           
            if (!File.Exists("riepiloghiRent.dat"))
            {
                DatBinaryFormatter.Save<List<Rent>>("riepiloghiRent.dat", _rentsRiepilogue.GetAll.ToList());
            }
          
            if (!File.Exists("riepiloghiInvoice.dat"))
            {
                DatBinaryFormatter.Save<List<Invoice>>("riepiloghiInvoice.dat", _invoicesRiepilogue.GetAll.ToList());
            }
        }

        private void onWarehouse(object sender, NotifyCollectionChangedEventArgs e)
        {
            XmlSerializerUtil.Save<List<Product>>("prodotti.xml",_warehouse.ProductList.ToList());
        }

        private void onRentsRiepilogue(object sender, NotifyCollectionChangedEventArgs e)
        {
            DatBinaryFormatter.Save<List<Rent>>("riepiloghiRent.dat",_rentsRiepilogue.GetAll.ToList());
        }

        private void onCustomerRiepilogue(object sender, NotifyCollectionChangedEventArgs e)
        {
            DatBinaryFormatter.Save<List<Customer>>("riepiloghiCustomer.dat", _costumerRiepilogue.GetAll.ToList());
        }

        private void onInvoiceRiepilogue(object sender, NotifyCollectionChangedEventArgs e)
        {
            DatBinaryFormatter.Save<List<Invoice>>("riepiloghiInvoice.dat", _invoicesRiepilogue.GetAll.ToList());
        }


        #region Proprietà
        #region REPOSITORY
        private List<Customer> _costumer;
        private List<Rent> _rents;
        private List<Product> _products;

        private RentRiepilogue _rentsRiepilogue;
        private CustomerRiepilogue _costumerRiepilogue;
        private InvoicesRiepilogue _invoicesRiepilogue;

        public RentRiepilogue RentsRiepilogue
        {
            get { return _rentsRiepilogue; }
            private set { _rentsRiepilogue = value; }
        }
        public CustomerRiepilogue CostumerRiepilogue
        {
            get { return _costumerRiepilogue; }
            private set { _costumerRiepilogue = value; }
        }
        public InvoicesRiepilogue InvoicesRiepilogue
        {
            get { return _invoicesRiepilogue; }
            set { _invoicesRiepilogue = value; }
        }
        public Warehouse Warehouse
        {
            get { return _warehouse; }
            private set { _warehouse = value; }
        }
        #endregion

        public string Logged
        {
            get
            {
                return _logged.Code;
            }
        }

        public ShoppingCart ShoppingCart
        {
            get
            {
                return _shoppingCart;
            }
        }
        #endregion

        #region Funzionalità core
       
        public bool Login(string username, string password)
        {
            if(String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))   
            {
                MessageBox.Show("Username oppure password non validi", "Login Perform", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (username=="admin" && password=="admin")
            {
                _logged = new Employee("admin","admin","admin");
                return true;
            }
            return false;
        }
        public Invoice InvoiceGenerator(GoodsMovement _goodsMovement, bool _toPay, double _discount, Customer _subject, string _employeeCode, bool _isPerc)
        {
            if (_isPerc)
            {
                return InvoiceFactory.CreateInvoice(UpdateProgressiveNumber(), _toPay, Services.CalculateDiscountPerc(_discount, Services.CalculateAmount(_goodsMovement)), _discount, _subject, new Employee(_employeeCode), _goodsMovement);
            }
            else return InvoiceFactory.CreateInvoice(UpdateProgressiveNumber(), _toPay, Services.CalculateAmountWithDiscount(Services.CalculateAmount(_goodsMovement), _discount), _discount, _subject, new Employee(_employeeCode), _goodsMovement);
        }
        public string ProductNumberGenerator(string type, string brand)
        {
            string firstCode = "00000";

            if (Warehouse.ProductList.Count == 0)
            {
                return Services.CalculateProductCode(type, brand, long.Parse(firstCode));
            }
            else
            {
                long productNumber = long.Parse(Warehouse.ProductList.Last().ProductCode.Substring(3, 5));

                return Services.CalculateProductCode(type, brand, ++productNumber);
            }  
        }
        public int UpdateProgressiveNumber()
        {
            if (InvoicesRiepilogue.GetAll.Count == 0)
            {
                return 1;
            }
            else
            {
                Invoice _last = InvoicesRiepilogue.GetAll.Last();
                InvoiceFactory.ProgressiveNumber = _last.ProgressiveNumber + 1;

                return InvoiceFactory.ProgressiveNumber;
            }
        }
        #endregion
    }
}
