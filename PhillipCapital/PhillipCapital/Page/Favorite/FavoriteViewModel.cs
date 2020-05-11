using PhillipCapital.Model.SearchFund;
using PhillipCapital.Utilities;
using System.Collections.ObjectModel;

namespace PhillipCapital.Page.Favorite
{
    public class FavoriteViewModel : BaseViewModel
    {
        private int _totalResult { get; set; }

        private ObservableCollection<FundResult> _listOfFavoriteFunds;
        public int TotalResult
        {
            get => _totalResult;

            set
            {
                _totalResult = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<FundResult> ListOfFavoriteFunds
        {
            get => _listOfFavoriteFunds;
            set
            {
                _listOfFavoriteFunds = value;
                NotifyPropertyChanged();
            }
        }

        public FavoriteViewModel()
        {
            GetFavoriteFunds();
            TotalResult = ListOfFavoriteFunds.Count;
        }

        private void GetFavoriteFunds()
        {
            ListOfFavoriteFunds = new ObservableCollection<FundResult>
            {
                new FundResult()
                    {FCode = "1a", FundName = "PRINCIPAL APDI", FundType = "FIF & Gold", FundLogoUrl = "fund_logo2"},
                new FundResult()
                    {FCode = "2b", FundName = "SCBRF", FundType = "FIF & Gold", FundLogoUrl = "fund_logo1"},
                new FundResult()
                    {FCode = "3c", FundName = "KFMTFI-D", FundType = "FIF & Gold", FundLogoUrl = "fund_logo"},
                new FundResult()
                    {FCode = "5e", FundName = "aCommerce", FundType = "FIF & Gold", FundLogoUrl = "fund_logo1"},
                new FundResult()
                    {FCode = "8f", FundName = "Bangkok Bank", FundType = "FIF & Gold", FundLogoUrl = "fund_logo"},
                new FundResult()
                {
                    FCode = "9f", FundName = "Devonshire Capital", FundType = "FIF & Gold", FundLogoUrl = "fund_logo",
                },
            };
        }
    }
}