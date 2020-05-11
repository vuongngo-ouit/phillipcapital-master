using PhillipCapital.Model.Dashboard;
using System.Collections.Generic;

namespace PhillipCapital.Model.Portfolio
{
    public class PortfolioModel : BaseModel
    {
        #region Fields

        private decimal _portfolioValue;
        private decimal _percentChange;
        private decimal _valueChange;
        private decimal _cost;
        private decimal _unrealizedReturn;
        private decimal _unrealizedProfit;
        private decimal _pMoneyValue;
        private string _lastUpdate;

        #endregion

        #region Properties

        public decimal PortfolioValue
        {
            get => _portfolioValue;
            set
            {
                _portfolioValue = value;
                OnPropertyChanged();
            }
        }
        public decimal PercentChange
        {
            get => _percentChange;
            set
            {
                _percentChange = value;
                OnPropertyChanged();
            }
        }
        public decimal ValueChange
        {
            get => _valueChange;
            set
            {
                _valueChange = value;
                OnPropertyChanged();
            }
        }
        public decimal Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged();
            }
        }
        public decimal UnrealizedReturn
        {
            get => _unrealizedReturn;
            set
            {
                _unrealizedReturn = value;
                OnPropertyChanged();
            }
        }
        public decimal UnrealizedProfit
        {
            get => _unrealizedProfit;
            set
            {
                _unrealizedProfit = value;
                OnPropertyChanged();
            }
        }

        public decimal PMoneyValue
        {
            get => _pMoneyValue;
            set
            {
                _pMoneyValue = value;
                OnPropertyChanged();
            }
        }
        public string LastUpdate
        {
            get => _lastUpdate;
            set
            {
                _lastUpdate = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }

    public class Risk
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }

    public class FundAsset : FundTopPickModel
    {
        #region Fields

        private decimal _units;
        private decimal _value;
        private decimal _unrealizedReturn;
        private decimal _unrealizedProfit;
        private decimal _cost;

        #endregion

        #region Properties

        public decimal Units
        {
            get => _units;
            set
            {
                _units = value;
                OnPropertyChanged();
            }
        }

        public decimal Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }
        public decimal UnrealizedReturn
        {
            get => _unrealizedReturn;
            set
            {
                _unrealizedReturn = value;
                OnPropertyChanged();
            }
        }
        public decimal UnrealizedProfit
        {
            get => _unrealizedProfit;
            set
            {
                _unrealizedProfit = value;
                OnPropertyChanged();
            }
        }
        public decimal Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
    public class Account : BaseModel
    {
        #region Fields
        private int _id;
        private string _name;
        private List<VirtualAccount> _virtualAccount;
        #endregion

        #region Properties
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public List<VirtualAccount> VirtualAccount
        {
            get => _virtualAccount;
            set
            {
                _virtualAccount = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }

    public class VirtualAccount : BaseModel
    {
        #region Fields
        private int _id;
        private string _name;
        #endregion

        #region Properties
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        #endregion

    }
}
