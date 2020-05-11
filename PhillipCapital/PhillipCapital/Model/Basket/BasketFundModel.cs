namespace PhillipCapital.Model.Basket
{
    public class BasketFundModel : FundModel
    {
        #region Fields
        private string _desc;
        private decimal _amount;
        private int _risk;
        private string _riskText;
        private string _color;

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
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}