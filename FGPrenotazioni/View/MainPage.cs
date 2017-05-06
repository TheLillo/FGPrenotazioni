using FGPrenotazioni.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.View
{
    public partial class MainPage : Form
    {
        

        public MainPage()
        {
            InitializeComponent();

            
        }

        public Label HomeLabel
        {
            get
            {
                return homeLabel;
            }
        }

        public Label SelectProductLabel
        {
            get
            {
                return selectLabel;
            }
        }


        public Label SearchLabelFatture
        {
            get
            {
                return showFattureLabel;
            }
        }

        public Label SearchLabelRent
        {
            get
            {
                return showRentLabel;
            }
        }
        public Label SearchSubjectLabel
        {
            get
            {
                return showSubjectLabel;
            }
        }

        public TableLayoutPanel TableLayoutPanel
        {
            get
            {
                return tableLayoutPanel;
            }
        }

        public Label UserLabel
        {
            get
            {
                return loggedUser;
            }
        }

        private void _homeLabel_Click(object sender, EventArgs e)
        {
            ColorReset(menuTableLayoutPanel);

            homeLabel.BackColor = Color.LightSlateGray;
            homeLabel.ForeColor = Color.White;

        }



        private void _homeLabel_MouseEnter(object sender, EventArgs e)
        {
            if (!(homeLabel.BackColor == Color.LightSlateGray))
            {
                homeLabel.BackColor = Color.LightGray;
                homeLabel.ForeColor = Color.Black;
            }
        }

        private void _homeLabel_MouseLeave(object sender, EventArgs e)
        {
            if (!(homeLabel.BackColor == Color.LightSlateGray))
            {
                homeLabel.BackColor = Color.White;
                homeLabel.ForeColor = Color.Black;
            }

        }
        private void ColorReset(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }
            }
        }

        private void _selectProductLabel_MouseEnter(object sender, EventArgs e)
        {
            if (!(selectLabel.BackColor == Color.LightSlateGray))
            {
                selectLabel.BackColor = Color.LightGray;
                selectLabel.ForeColor = Color.Black;
            }
        }

        private void _selectProductLabel_MouseLeave(object sender, EventArgs e)
        {
            if (!(selectLabel.BackColor == Color.LightSlateGray))
            {
                selectLabel.BackColor = Color.White;
                selectLabel.ForeColor = Color.Black;
            }
        }

        private void _selectProductLabel_Click(object sender, EventArgs e)
        {
            ColorReset(menuTableLayoutPanel);

            selectLabel.BackColor = Color.LightSlateGray;
            selectLabel.ForeColor = Color.White;

        }

        private void _searchLabelRent_MouseEnter(object sender, EventArgs e)
        {
            if (!(SearchLabelRent.BackColor == Color.LightSlateGray))
            {
                SearchLabelRent.BackColor = Color.LightGray;
                SearchLabelRent.ForeColor = Color.Black;
            }
        }

        private void _searchLabelRent_MouseLeave(object sender, EventArgs e)
        {
            if (!(SearchLabelRent.BackColor == Color.LightSlateGray))
            {
                SearchLabelRent.BackColor = Color.White;
                SearchLabelRent.ForeColor = Color.Black;
            }
        }

        private void _searchLabelRent_Click(object sender, EventArgs e)
        {
            ColorReset(menuTableLayoutPanel);

            SearchLabelRent.BackColor = Color.LightSlateGray;
            SearchLabelRent.ForeColor = Color.White;

        }

        private void _searchLabelFatture_MouseEnter(object sender, EventArgs e)
        {
            if (!(SearchLabelFatture.BackColor == Color.LightSlateGray))
            {
                SearchLabelFatture.BackColor = Color.LightGray;
                SearchLabelFatture.ForeColor = Color.Black;
            }
        }

        private void _searchLabelFatture_MouseLeave(object sender, EventArgs e)
        {
            if (!(SearchLabelFatture.BackColor == Color.LightSlateGray))
            {
                SearchLabelFatture.BackColor = Color.White;
                SearchLabelFatture.ForeColor = Color.Black;
            }
        }

        private void _searchLabelFatture_Click(object sender, EventArgs e)
        {
            ColorReset(menuTableLayoutPanel);

            SearchLabelFatture.BackColor = Color.LightSlateGray;
            SearchLabelFatture.ForeColor = Color.White;

        }

        private void _searchSubjectLabel_MouseEnter(object sender, EventArgs e)
        {
            if (!(SearchSubjectLabel.BackColor == Color.LightSlateGray))
            {
                SearchSubjectLabel.BackColor = Color.LightGray;
                SearchSubjectLabel.ForeColor = Color.Black;
            }
        }

        private void _searchSubjectLabel_MouseLeave(object sender, EventArgs e)
        {
            if (!(SearchSubjectLabel.BackColor == Color.LightSlateGray))
            {
                SearchSubjectLabel.BackColor = Color.White;
                SearchSubjectLabel.ForeColor = Color.Black;
            }
        }

        private void _searchSubjectLabel_Click(object sender, EventArgs e)
        {
            ColorReset(menuTableLayoutPanel);

            SearchSubjectLabel.BackColor = Color.LightSlateGray;
            SearchSubjectLabel.ForeColor = Color.White;

        }

        private void _logoutLabel_Click(object sender, EventArgs e)
        {
            ColorReset(mainTableLayout);

            UserLabel.BackColor = Color.LightSlateGray;
            UserLabel.ForeColor = Color.White;

        }
        private void _logoutLabel_MouseEnter(object sender, EventArgs e)
        {
            if (!(UserLabel.BackColor == Color.LightSlateGray))
            {
                UserLabel.BackColor = Color.LightGray;
                UserLabel.ForeColor = Color.Black;
            }
        }
        private void _logoutLabel_MouseLeave(object sender, EventArgs e)
        {
            if (!(UserLabel.BackColor == Color.LightSlateGray))
            {
                UserLabel.BackColor = Color.White;
                UserLabel.ForeColor = Color.Black;
            }

        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Visible)
            {
                if (MessageBox.Show("Uscire da FGPrenotazioni?", Application.ProductName.ToString(), MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
    }
}
