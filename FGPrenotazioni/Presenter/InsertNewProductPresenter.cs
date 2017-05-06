using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.View;
using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Products;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;

namespace FGPrenotazioni.Presenter
{

    class InsertNewProductPresenter : Presenter
    {
        public InsertNewProductForm View
        {
            get
            {
                return (InsertNewProductForm)Element;
            }
        }

        public InsertNewProductPresenter(InsertNewProductForm view) :base(view)
        {
            populateView();
            View.ConfermaButton.Click += onConfirmClick;
            View.BackButton.Click += onBackClick;
            View.TipologiaCombo.SelectedIndexChanged += onTipologiaComboChanged;
        }
        
        private void populateView()
        {
            foreach(Type t in typeof(Product).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Product)) && !t.IsAbstract))
            {
                View.TipologiaCombo.Items.Add(t.Name);
            }
            View.TipologiaCombo.SelectedIndex = 0;

            populateCategory();

        }

        public void populateCategory()
        {
            View.CategoryCombo.Items.Clear();

            string productType = View.TipologiaCombo.SelectedItem.ToString();
            productType = productType.Replace("Product", String.Empty);

            Type enumType=typeof(Product).Assembly.GetTypes().Where(t => t.IsEnum && t.Name.Contains("Category") && t.Name.Contains(productType)).First();

            View.CategoryCombo.Items.AddRange(Enum.GetNames(enumType));
            View.CategoryCombo.SelectedIndex = 0;
            
        }
        
        private void onConfirmClick(object sender,EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(View.DescrizioneText.Text.Trim()) && String.IsNullOrWhiteSpace(View.MarcaText.Text.Trim()) && String.IsNullOrWhiteSpace(View.NoleggioText.Text.Trim())&&String.IsNullOrWhiteSpace(View.VenditaText.Text.Trim()))
            {
                MessageBox.Show("Inserire tutti i campi del prodotto", "INSERIMENTO PRODOTTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string productType = View.TipologiaCombo.SelectedItem.ToString();
                    productType = productType.Replace("Product", String.Empty);
                    Type enumType = typeof(Product).Assembly.GetTypes().Where(t => t.IsEnum && t.Name.Contains("Category") && t.Name.Contains(productType)).First();
                    string category = View.CategoryCombo.SelectedItem.ToString();
                    object[] constructorArgs = new object[8];

                 

                    constructorArgs[1] = View.DescrizioneText.Text;
                    constructorArgs[2] = Services.RoundToTwo(double.Parse(View.VenditaText.Text));
                    constructorArgs[3] = Services.RoundToTwo(double.Parse(View.NoleggioText.Text));
                    constructorArgs[4] = true;
                    constructorArgs[5] = true;
                    constructorArgs[6] = View.MarcaText.Text;
                    constructorArgs[7] = Enum.Parse(enumType, category);
                    constructorArgs[0] = FGManager.Instance.ProductNumberGenerator(productType,constructorArgs[6].ToString());


                    Type selected = typeof(Product).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Product)) && !t.IsAbstract && t.Name == View.TipologiaCombo.SelectedItem.ToString()).First();

                    Product result = Activator.CreateInstance(selected, constructorArgs) as Product;


                    FGManager.Instance.Warehouse.AddProduct(result);

                    MessageBox.Show("Prodotto inserito con successo");

                    GestoreView.GetInstance().MostraView(typeof(MainPage),typeof(MainPagePresenter));
                    GestoreView.GetInstance().ChiudiView(typeof(InsertNewProductForm));


                } catch(Exception)
                {
                    MessageBox.Show("Errore nell'inserimento dei parametri");
                }
               
            }


        }
        
        private void onBackClick(object sender,EventArgs e)
        {
            GestoreView.GetInstance().MostraView(typeof(MainPage),typeof(MainPagePresenter));
            GestoreView.GetInstance().ChiudiView(typeof(InsertNewProductForm));
        }
        private void onTipologiaComboChanged(object sender,EventArgs e)
        {
            populateCategory();

        }
    }
}
