﻿using PhillipCapital.Utilities;
using System;
using PhillipCapital.Page.Summary;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.Page.Basket.BasketPaymentOption
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasketPaymentOption : ContentPage
    {
        public BasketPaymentOption()
        {
            InitializeComponent();
            InitUI();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Handle_PaymentPickerSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            if (!(sender is Picker picker))
            {
                return;
            }

            BankAccountLayout.IsVisible = picker.SelectedItem.ToString() == BasKetPaymentMethod.ATS.ToValue();
            OrderDateLayout.IsVisible = picker.SelectedItem.ToString() != BasKetPaymentMethod.ATS.ToValue() 
                                        || (picker.SelectedItem.ToString() == BasKetPaymentMethod.ATS.ToValue() && BankAccountPicker.SelectedIndex > -1);
            PMoneyInfoGrid.IsVisible = picker.SelectedItem.ToString() == BasKetPaymentMethod.PMoney.ToValue();
        }

        private void Handle_BankAccountPickerSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            if (!(sender is Picker picker))
            {
                return;
            }

            OrderDateLayout.IsVisible = picker.SelectedIndex > -1;
        }

        private void InitUI()
        {
            BtnReviewSummary.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => { Navigation.PushAsync(new ReviewSummary(), true); })
            });
        }
    }
}