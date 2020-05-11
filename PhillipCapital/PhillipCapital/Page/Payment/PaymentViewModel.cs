using System;
using System.Collections.ObjectModel;
using PhillipCapital.Model.Payment;
using PhillipCapital.Utilities;

namespace PhillipCapital.Page.Payment
{
    public class PaymentViewModel : BaseViewModel
    {
        private ObservableCollection<WarningFundModel> _warningFunds;

        public ObservableCollection<WarningFundModel> WarningFunds
        {
            get => _warningFunds;
            set
            {
                _warningFunds = value;
                NotifyPropertyChanged();
            }
        }

        public string Text { get; set; }

        public PaymentViewModel()
        {
            GetWarningFunds();
            RandomText();
        }

        private void GetWarningFunds()
        {
            var rd = new Random();
            WarningFunds = new ObservableCollection<WarningFundModel>
            {
                new WarningFundModel{FundName = "PRINCIPAL APDI", Description = "Principal Asia Pacific Dynamic Income Equity Fund", Amount = rd.Next(40000, 50000), Risk = rd.Next(5,8), RiskText = "Medium Risk", Color = "Orange"},
                new WarningFundModel{FundName = "KFMTFI-D", Description = "Siam Commercial Bank Retirement Fund", Amount = rd.Next(40000, 50000), Risk = rd.Next(5,8), RiskText = "High Risk", Color = "#E8756F"},
                new WarningFundModel{FundName = "SHADFORTH",Description = "Krungsri Medium Term Fixed Income Divident Fund", Amount = rd.Next(40000, 50000), Risk = rd.Next(5,8), RiskText = "Medium Risk", Color = "Orange"},
                new WarningFundModel{FundName = "MAPKATS",Description = "Principal Asia Pacific Dynamic Income Equity Fund", Amount = rd.Next(40000, 50000), Risk = rd.Next(5,8), RiskText = "High Risk", Color = "#E8756F"},
                new WarningFundModel{FundName = "iCENTRAL",Description = "Siam Commercial Bank Retirement Fund", Amount = rd.Next(40000, 50000), Risk = rd.Next(5,8), RiskText = "Medium Risk", Color = "Orange"},
            };
        }

        private void RandomText()
        {
            Text = "I confirm to execute this subscription order that invests in risk assets higher than my accepted risk level," +
                   " Phillip Securities has explained risk on this mutual fund to me that this mutual fund has volatile in value of its asset." +
                   " It may make loss to my investment, I may receive sale proceed less than my initial investment.";
        }
    }
}
