using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FGPrenotazioni.View;
using FGPrenotazioni.Models;

namespace FGPrenotazioni.Presenter
{
    public class MainPagePresenter : Presenter
    {
        private HomeList _homeList;
        private SelezionaProdotti _selectProduct;
        private MostraSubject _subject;
        private MostraFatture _fatture;
        private MostraNoleggi _noleggi;
        public MainPage MainPage
        {
            get
            {
                return (MainPage)Element;
            }
        }
        public MainPagePresenter(MainPage view) : base(view)
        {
            _homeList = new HomeList();
            _selectProduct = new SelezionaProdotti();
            _subject = new MostraSubject();
            _fatture = new MostraFatture();
            _noleggi = new MostraNoleggi();
            MainPage.HomeLabel.Click += onHomeClick;
            MainPage.SearchLabelFatture.Click += onSearchLabelFattureClick;
            MainPage.SearchLabelRent.Click += onSearchLabelRentClick;
            MainPage.SearchSubjectLabel.Click += onSearchLabelSubjectClick;
            MainPage.SelectProductLabel.Click += onSelectProductLabelClick;
            MainPage.UserLabel.Click += onUserLabelClick;
      
            //a default si apre la Home
            HomeClick();
        }
        private void onHomeClick(object sender, EventArgs e)
        {
            HomeClick();
        }
        private void onUserLabelClick(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            GestoreView.GetInstance().NascondiView(typeof(MainPage));
            GestoreView.GetInstance().MostraView(typeof(LoginForm),typeof(LoginPresenter));
        }

        private void onSelectProductLabelClick(object sender, EventArgs e)
        {
            SelezionaClick();
        }

        private void onSearchLabelSubjectClick(object sender, EventArgs e)
        {
            SubjectClick();
        }



        private void onSearchLabelRentClick(object sender, EventArgs e)
        {
            MostraNoleggiClick();
        }

 

        private void onSearchLabelFattureClick(object sender, EventArgs e)
        {
            MostraFattureClick();
        }
        private void MostraNoleggiClick()
        {
            _noleggi = new MostraNoleggi();
            MostraNoleggiPresenter p = new MostraNoleggiPresenter(_noleggi);
            MainPage.TableLayoutPanel.Controls.Clear();
            MainPage.TableLayoutPanel.Controls.Add(_noleggi);
        }
        private void MostraFattureClick()
        {
            _fatture = new MostraFatture();
            MostraFatturePresenter p = new MostraFatturePresenter(_fatture);
            MainPage.TableLayoutPanel.Controls.Clear();
            MainPage.TableLayoutPanel.Controls.Add(_fatture);
        }

        private void HomeClick()
        {
            _homeList = new HomeList();
            HomeListPresenter p = new HomeListPresenter(_homeList);
            MainPage.TableLayoutPanel.Controls.Clear();
            MainPage.TableLayoutPanel.Controls.Add(_homeList);
            MainPage.UserLabel.Text = FGManager.Instance.Logged + "   (LOGOUT)";
        }

        private void SelezionaClick()
        {
            
            _selectProduct=new SelezionaProdotti();
            SelezionaProdottiPresenter p = new SelezionaProdottiPresenter(_selectProduct);
            MainPage.TableLayoutPanel.Controls.Clear();
            MainPage.TableLayoutPanel.Controls.Add(_selectProduct);
        }
        private void SubjectClick()
        {
            _subject = new MostraSubject();
            MostraSubjectPresenter p = new MostraSubjectPresenter(_subject);
            MainPage.TableLayoutPanel.Controls.Clear();
            MainPage.TableLayoutPanel.Controls.Add(_subject);
        }
    }
}
