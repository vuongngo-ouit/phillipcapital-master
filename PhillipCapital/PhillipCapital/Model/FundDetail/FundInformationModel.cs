namespace PhillipCapital.Model.FundDetail
{
    public class FundInformationModel : BaseModel
    {
        #region Fields

        private string _fundType;
        private string _fundTypeDesc;
        private string _fundOwner;
        private string _registeredDate;
        private decimal _minimumInvestment;
        private decimal _minimum1stInvestment;
        private string _dayOfRedemption;
        private int _top10Holding;
        private decimal _firstPurchase;
        private decimal _nextPurchase;
        private decimal _minimumSellingPrice;
        private string _aTS;
        private string _pMoney;
        private string _sellCloseTime;
        private decimal _frontEndPurchaseFee;
        private decimal _backEndSalesFee;
        private decimal _brokerageFee;
        private decimal _managementFee;
        private decimal _totalExpenseRatio;

        #endregion

        #region Properties

        public string FundType
        {
            get => _fundType;
            set
            {
                _fundType = value;
                OnPropertyChanged();
            }
        }
        public string FundTypeDesc
        {
            get => _fundTypeDesc;
            set
            {
                _fundTypeDesc = value;
                OnPropertyChanged();
            }
        }
        public string FundOwner
        {
            get => _fundOwner;
            set
            {
                _fundOwner = value;
                OnPropertyChanged();
            }
        }
        public string RegisteredDate
        {
            get => _registeredDate;
            set
            {
                _registeredDate = value;
                OnPropertyChanged();
            }
        }
        public decimal MinimumInvestment
        {
            get => _minimumInvestment;
            set
            {
                _minimumInvestment = value;
                OnPropertyChanged();
            }
        }
        public decimal Minimum1stInvestment
        {
            get => _minimum1stInvestment;
            set
            {
                _minimum1stInvestment = value;
                OnPropertyChanged();
            }
        }
        public string DayOfRedemption
        {
            get => _dayOfRedemption;
            set
            {
                _dayOfRedemption = value;
                OnPropertyChanged();
            }
        }
        public int Top10Holding
        {
            get => _top10Holding;
            set
            {
                _top10Holding = value;
                OnPropertyChanged();
            }
        }
        public decimal FirstPurchase
        {
            get => _firstPurchase;
            set
            {
                _firstPurchase = value;
                OnPropertyChanged();
            }
        }
        public decimal NextPurchase
        {
            get => _nextPurchase;
            set
            {
                _nextPurchase = value;
                OnPropertyChanged();
            }
        }
        public decimal MinimumSellingPrice
        {
            get => _minimumSellingPrice;
            set
            {
                _minimumSellingPrice = value;
                OnPropertyChanged();
            }
        }
        public string ATS
        {
            get => _aTS;
            set
            {
                _aTS = value;
                OnPropertyChanged();
            }
        }
        public string PMoney
        {
            get => _pMoney;
            set
            {
                _pMoney = value;
                OnPropertyChanged();
            }
        }
        public string SalesClosingTime
        {
            get => _sellCloseTime;
            set
            {
                _sellCloseTime = value;
                OnPropertyChanged();
            }
        }
        public decimal FrontEndPurchaseFee
        {
            get => _frontEndPurchaseFee;
            set
            {
                _frontEndPurchaseFee = value;
                OnPropertyChanged();
            }
        }
        public decimal BackEndSalesFee
        {
            get => _backEndSalesFee;
            set
            {
                _backEndSalesFee = value;
                OnPropertyChanged();
            }
        }
        public decimal BrokerageFee
        {
            get => _brokerageFee;
            set
            {
                _brokerageFee = value;
                OnPropertyChanged();
            }
        }
        public decimal ManagementFee
        {
            get => _managementFee;
            set
            {
                _managementFee = value;
                OnPropertyChanged();
            }
        }
        public decimal TotalExpenseRatio
        {
            get => _totalExpenseRatio;
            set
            {
                _totalExpenseRatio = value;
                OnPropertyChanged();
            }
        }
        #endregion

    }
}
