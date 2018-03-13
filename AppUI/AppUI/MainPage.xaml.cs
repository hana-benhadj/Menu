using AppUI.Model;
using AppUI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppUI
{
	public partial class MainPage : MasterDetailPage
	{
        public MainPage()
        {
            InitializeComponent();
            Detail = new Page1();
            
            List<List> L = new List<List>
            {
               new List { Title = "My ACCOUNT" },
               new List {Title ="SHOP"},
               new List {Title ="FAQ"},
               new List {Title ="NOTIFICATION" , Notification="2"}
            };
            ListView1.ItemsSource = L;


        }



        void SeelectedItem(object sender, EventArgs e)
        {
            var l = ListView1.SelectedItem as List;

            if ( l.Title == "My ACCOUNT")
            {
                Detail = new MyAccount();
                IsPresented = false;
               
            }
            if (l.Title == "Shop")
            {
                Detail = new Shop();
                IsPresented = false;
            }
            if (l.Title == "FAQ")
            {
                Detail = new FAQ();
                IsPresented = false;
            }
            if (l.Title == "Notification")
            {
                Detail = new Notification();
                IsPresented = false;
            }


        }
    }
}
