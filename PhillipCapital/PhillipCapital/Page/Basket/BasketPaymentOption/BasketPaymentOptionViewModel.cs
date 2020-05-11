using PhillipCapital.Utilities;
using System.Collections.ObjectModel;

namespace PhillipCapital.Page.Basket.BasketPaymentOption
{
    public class BasketPaymentOptionViewModel : BaseViewModel
    {
        private ObservableCollection<string> _paymentMethods;
        private ObservableCollection<string> _listOfBank;

        public ObservableCollection<string> PaymentMethods
        {
            get => _paymentMethods;
            set
            {
                _paymentMethods = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<string> ListOfBank
        {
            get => _listOfBank;
            set
            {
                _listOfBank = value;
                NotifyPropertyChanged();
            }
        }

        public BasketPaymentOptionViewModel()
        {
            GetPaymentMethods();
            GetListOfBank();
        }

        private void GetListOfBank()
        {
            ListOfBank = new ObservableCollection<string>
            {
                {"Vietcombank"},
                {"HSBC"},
                {"TPBank"},
                {"Techcombank"}
            };
        }

        private void GetPaymentMethods()
        {
            PaymentMethods = new ObservableCollection<string>
            {
                {BasKetPaymentMethod.PayIn.ToValue()},
                {BasKetPaymentMethod.ATS.ToValue()},
                {BasKetPaymentMethod.Prepaid.ToValue()},
                {BasKetPaymentMethod.PMoney.ToValue()},
            };
        }
    }
}