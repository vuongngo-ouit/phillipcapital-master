using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.Page.Basket
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasketPage : ContentPage
    {
        public BasketPage()
        {
            InitializeComponent();
            InitUI();
            NavigationPage.SetHasNavigationBar(this, false);
            AccountPicker.SelectedIndex = 0;
        }

        private void InitUI()
        {
            BtnPayment.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => { Navigation.PushAsync(new BasketPaymentOption.BasketPaymentOption(), true); })
            });
        }
    }
}