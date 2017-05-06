using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGPrenotazioni.Models;
using System.Windows.Forms;
using FGPrenotazioni.View;

namespace FGPrenotazioni.Presenter
{
    public class LoginPresenter : Presenter
    {

        public LoginForm LoginForm
        {
            get
            {
                return (LoginForm)Element;
            }
        }

        public LoginPresenter(LoginForm view):base(view)
        {

            LoginForm.LogButton.Click += onLoginClick;
          
        }

        private void onLoginClick(object sender,EventArgs e)
        {
            CheckLogin();
        }
       

        public void CheckLogin()
        {
            if (FGManager.Instance.Login(LoginForm.Username.Text, LoginForm.Password.Text))
            {
                GestoreView.GetInstance().RimuoviView(typeof(MainPage));
                GestoreView.GetInstance().MostraView(typeof(MainPage),typeof(MainPagePresenter));
                GestoreView.GetInstance().NascondiView(typeof(LoginForm));
            }
            else
            {
                MessageBox.Show("Username oppure password non validi","Login Perform", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  
        
    }
}
