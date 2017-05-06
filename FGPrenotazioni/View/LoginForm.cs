using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.Presenter;

namespace FGPrenotazioni.View
{
    public partial class LoginForm : Form
    {
        
            public LoginForm()
        {
            InitializeComponent();
            
        }


        public TextBox Password
        {
            get
            {
                return this.passwordBox;
            }

            set
            {
                this.passwordBox = value;
            }
        }

        public TextBox Username
        {
            get
            {
                return this.usernameBox;
            }

            set
            {
                this.usernameBox = value;
            }
        }

        public Button LogButton
        {
            get
            {
                return this.loginButton;
            }
            set
            {
                this.loginButton = value;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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
