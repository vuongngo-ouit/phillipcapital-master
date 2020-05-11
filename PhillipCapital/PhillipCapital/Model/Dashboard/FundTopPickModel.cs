using PhillipCapital.Helper;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PhillipCapital.Model.Dashboard
{
    public class FundTopPickModel : FundModel
    {
        #region Fields

        private string _fundDesc;
        private string _fundType;
        private decimal _fundValue;
        private decimal _valueChangePercent;
        private decimal _valueChange;
        private string _navDate;
        private int _riskLevel;
        private string _riskColor;
        private string _fundLogoUrl;
        private bool _isFavorite;

        #endregion

        #region Properties

        public string FundDescription
        {
            get => _fundDesc;
            set
            {
                _fundDesc = value;
                OnPropertyChanged();
            }
        }

        public string FundType
        {
            get => _fundType;
            set
            {
                _fundType = value;
                OnPropertyChanged();
            }
        }

        public decimal FundValue
        {
            get => _fundValue;
            set
            {
                _fundValue = value;
                OnPropertyChanged();
            }
        }

        public decimal ValueChangePercent
        {
            get => _valueChangePercent;
            set
            {
                _valueChangePercent = value;
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
        public string NavDate
        {
            get => _navDate;
            set
            {
                _navDate = value;
                OnPropertyChanged();
            }
        }
        public int RiskLevel
        {
            get => _riskLevel;
            set
            {
                _riskLevel = value;
                OnPropertyChanged();
            }
        }
        public string RiskColor
        {
            get => _riskColor;
            set
            {
                _riskColor = value;
                OnPropertyChanged();
            }
        }
        public string FundLogoUrl
        {
            get => _fundLogoUrl;
            set
            {
                _fundLogoUrl = value;
                OnPropertyChanged();
            }
        }

        public bool IsFavorite
        {
            get => _isFavorite;
            set
            {
                _isFavorite = value;
                OnPropertyChanged();
            }
        }

        public string FavoriteIcon => IsFavorite ? ResourceHelper.RedHeartIcon : ResourceHelper.BlackHeartIcon;

        #endregion

        #region Methods

        /// <summary>
        /// The PropertyChanged event occurs when property value is changed.
        /// </summary>
        /// <param name="property">property name</param>
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        #endregion
    }
}
