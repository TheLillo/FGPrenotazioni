using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Presenter
{
    class GestoreView
    {
        private static Dictionary<Type, Form> _views;
        private static GestoreView _instance = null;
        private GestoreView()
        {
            _views = new Dictionary<Type, Form>();
        }

        public static GestoreView GetInstance()
        {
            if (_instance == null) _instance = new GestoreView();
            return _instance;
        }

        public Form GetView(Type tipo)
        {
            if (!_views.ContainsKey(tipo))
            {
                Form nuovaForm = (Form)Activator.CreateInstance(tipo);
                _views.Add(tipo, nuovaForm);
            }

            return _views[tipo];
        }
        public void MostraView(Type tipo,Type presenter)
        {
            if (!_views.ContainsKey(tipo))
            {
                Form nuovaForm = (Form)Activator.CreateInstance(tipo);
                Presenter p=(Presenter)Activator.CreateInstance(presenter, nuovaForm);

                _views.Add(tipo, nuovaForm);
            }

            _views[tipo].Show();
        }

        public void RimuoviView(Type tipo)
        {
            if (_views.ContainsKey(tipo))
            {
                _views.Remove(tipo);
            }
        }

        public void NascondiView(Type tipo)
        {
            if (_views.ContainsKey(tipo))
            {
                _views[tipo].Hide();
            }
            else
            {
                throw new ArgumentException("View Inesistente");
            }
        }

     

        public void ChiudiView(Type tipo)
        {
            if (_views.ContainsKey(tipo))
            {
                _views[tipo].Close();
                RimuoviView(tipo);
            }
        }
    }
}
