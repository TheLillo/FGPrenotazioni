using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.View;
using FGPrenotazioni.Presenter;
using FGPrenotazioni.Models;
using FGPrenotazioni.Models.Products;

namespace FGPrenotazioni
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
   
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GestoreView.GetInstance().MostraView(typeof(LoginForm),typeof(LoginPresenter));
            Application.Run();

        }
    }
}
