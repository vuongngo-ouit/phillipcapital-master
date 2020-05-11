using PhillipCapital.Page.Dashboard;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace PhillipCapital
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var loginPage = new DashboardPage();
            Application.Current.MainPage = new NavigationPage(loginPage);
        }
    }
}
