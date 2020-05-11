using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PhillipCapital.Model.Payment
{
    public class WarningFundModel : FundModel
    {
        #region Fields

        private string _desc;
        private decimal _amount;
        private int _risk;
        private string _riskText;
        private string _Color;

        #endregion

        #region Properties

        public string Description
        {
            get => _desc;
            set
            {
                _desc = value;
                OnPropertyChanged();
            }
        }

        public decimal Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged();
            }
        }

        public int Risk
        {
            get => _risk;
            set
            {
                _risk = value;
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

        public string Color
        {
            get => _Color;
            set
            {
                _Color = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}