using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.Page.Portfolio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PortfolioPage : ContentPage
    {

        public PortfolioPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new SelectAccountPage(), false);
        }
    }
}