using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.Presenter;

namespace FGPrenotazioni.View
{
    public partial class HomeList : UserControl
    {
       
        public HomeList()
        {
            InitializeComponent();
            
        }

        public Button AddButton
        {
            get { return addButton; }
        }
        public Button RemoveButton
        {
            get { return removeButton;}
        }
        public DataGridView WarehouseDataGrid
        {
            get { return warehouseDataGridView; }
        }
    }
}
