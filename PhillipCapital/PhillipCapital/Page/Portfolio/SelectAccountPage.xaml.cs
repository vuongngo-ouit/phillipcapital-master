using System;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.Page.Portfolio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectAccountPage : PopupPage
    {
        public SelectAccountPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync();
        }
    }
}