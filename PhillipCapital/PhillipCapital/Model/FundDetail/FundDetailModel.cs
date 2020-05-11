using System;
using System.Collections.Generic;
using System.Text;
using PhillipCapital.Model.Dashboard;

namespace PhillipCapital.Model.FundDetail
{
    public class FundDetailModel : FundTopPickModel
    {
        #region Fields

        private decimal _buy;
        private decimal _sell;
        private string _riskText;

        #endregion

        #region Properties

        public decimal Buy
        {
            get => _buy;
            set
            {
                _buy = value;
                OnPropertyChanged();
            }
        }
        public decimal Sell
        {
            get => _sell;
            set
            {
                _sell = value;
                OnPropertyChanged();
            }
        }
        public string RiskText
        {
            get => _riskText;
            set
            {
                _riskText = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public class Person
        {
            public string Name { get; set; }

            public double Height { get; set; }
        }
    }
}
