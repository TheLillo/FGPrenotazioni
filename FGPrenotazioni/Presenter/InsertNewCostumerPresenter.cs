using FGPrenotazioni.Models;
using FGPrenotazioni.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGPrenotazioni.Presenter
{
    class InsertNewCostumerPresenter : Presenter
    {
        public InsertNewCustumer View
        {
            get
            {
                return (InsertNewCustumer)Element;
            }
        }
        public InsertNewCostumerPresenter(InsertNewCustumer view) : base(view)
        {
            View.Conferma.Click += OnConfermaClick;
            View.Indietro.Click += OnIndietroClick;
        }

        public void OnConfermaClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(View.CreditCard.Text) || string.IsNullOrWhiteSpace(View.Email.Text) || string.IsNullOrWhiteSpace(View.Denomination.Text) || string.IsNullOrWhiteSpace(View.NumberCell.Text) || string.IsNullOrWhiteSpace(View.Street.Text) || string.IsNullOrWhiteSpace(View.NumeroCivico.Text) || string.IsNullOrWhiteSpace(View.CAP.Text) || string.IsNullOrWhiteSpace(View.City.Text) || string.IsNullOrWhiteSpace(View.Province.Text) || string.IsNullOrWhiteSpace(View.Nazione.Text) || string.IsNullOrWhiteSpace(View.ID.Text))
            {
                MessageBox.Show("Devi inserire tutti i campi", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (FGManager.Instance.CostumerRiepilogue.GetAll.Where(s => s.ID == View.ID.Text).ToList().Count==0) {
                    try
                    {
                        Address newAddress = new Address(View.Street.Text, View.NumeroCivico.Text, View.City.Text, View.CAP.Text, View.Province.Text, View.Nazione.Text);
                        if (View.Company.Checked)
                        {
                            Company newCompany = new Company(View.Denomination.Text, View.CreditCard.Text, View.NumberCell.Text, View.Email.Text, true, newAddress, View.ID.Text);
                            FGManager.Instance.CostumerRiepilogue.Add(newCompany);
                        }
                        else if (View.PrivateSubject.Checked)
                        {
                            PrivateClient newPrivateClient = new PrivateClient(View.Denomination.Text, View.CreditCard.Text, View.NumberCell.Text, View.Email.Text, true, newAddress, View.ID.Text);
                            FGManager.Instance.CostumerRiepilogue.Add(newPrivateClient);
                        }
                        MessageBox.Show("Inserimento cliente avvenuto con successo");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Errore imprevisto nella creazione del cliente");
                    }
                }else
                {
                    MessageBox.Show("Cliente già esistente", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                tornaIndietro();
            }
        }

        public void OnIndietroClick(object sender, EventArgs e)
        {
            tornaIndietro();
        }

        private void tornaIndietro()
        {
            bool inMain = true;
            FormCollection fc = Application.OpenForms;

            foreach (Form fm in fc)
            {
                if (fm is MostraSubAfterShoppingNolo)
                {
                    GestoreView.GetInstance().MostraView(typeof(MostraSubAfterShoppingNolo), typeof(MostraSubjectFromShoppingNoloPresenter));
                    GestoreView.GetInstance().ChiudiView(typeof(InsertNewCustumer));
                    inMain = false;
                    break;
                }
                else if (fm is MostraSubAfterShoppingVendita)
                {
                    GestoreView.GetInstance().MostraView(typeof(MostraSubAfterShoppingVendita), typeof(MostraSubjectFromShoppingPresenterVendita));
                    GestoreView.GetInstance().ChiudiView(typeof(InsertNewCustumer));
                    inMain = false;
                    break;
                }

            }

            if (inMain)
            {
                GestoreView.GetInstance().MostraView(typeof(MainPage), typeof(MainPagePresenter));
                GestoreView.GetInstance().ChiudiView(typeof(InsertNewCustumer));
            }

        }

    }
}
