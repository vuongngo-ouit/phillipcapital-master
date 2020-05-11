using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using PhillipCapital.Model.SearchFund;
using PhillipCapital.Utilities;
using Xamarin.Forms;

namespace PhillipCapital.Page.SearchFund
{
    public class SearchFundViewModel : BaseViewModel
    {
        #region Fields

        private int _totalResult;
        private ObservableCollection<FundResult> _fundResult;
        private ObservableCollection<FundResult> _listItem;
        private ObservableCollection<FundResult> _listItemFilter;
        private string _searchText;
        public Command SearchCommand { get; set; }
        private ObservableCollection<FilterPeriodModel> _listPeriod;

        #endregion

        #region Properties

        public ObservableCollection<FilterPeriodModel> ListPeriod
        {
            get => _listPeriod;
            set
            {
                _listPeriod = value;
                NotifyPropertyChanged();
            }
        }
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                NotifyPropertyChanged(nameof(SearchText));
            }
        }
        public int TotalResult
        {
            get => _totalResult;
            set
            {
                _totalResult = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<FundResult> ListFundResults
        {
            get => _fundResult;
            set
            {
                _fundResult = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Structure

        public SearchFundViewModel()
        {
            GetListTopPickFund();
            TotalResult = ListFundResults.Count;
            _listItem = ListFundResults;
            SearchCommand = new Command(PerformSearch);
        }

        #endregion


        public void OnSelectFilterPeriod(string periodName)
        {
            
        }

        private void PerformSearch(object obj)
        {
            if (string.IsNullOrWhiteSpace(_searchText))
            {
                ListFundResults = _listItem;
                TotalResult = ListFundResults.Count;
            }
            else
            {
                _listItemFilter = new ObservableCollection<FundResult>(_listItem
                    .Where(i => i != null && ((FundResult)i).FundName.ToLower().Contains(_searchText.ToLower())));

                ListFundResults = _listItemFilter;
                TotalResult = ListFundResults.Count;
            }
        }

        #region GetData

        private void GetListTopPickFund()
        {
            Random rd = new Random();
            ListFundResults = new ObservableCollection<FundResult>
            {
                new FundResult(){FCode = "1a",FundName = "PRINCIPAL APDI",IsFavorite = false,FundDescription = "Principal Asia Pacific Dynamic Income Equity Fund", FundType = "FIF & Gold", FundLogoUrl = "fund_logo2", FundValue = rd.Next(14, 50), ValueChangePercent = rd.Next(1,5) /10m, ValueChange = rd.Next(3,10) /10m},
                new FundResult(){FCode = "2b",FundName = "SCBRF",IsFavorite = false,FundDescription = "Siam Commercial Bank Retirement Fund", FundType = "FIF & Gold", FundLogoUrl = "fund_logo1", FundValue = rd.Next(14, 50), ValueChangePercent = rd.Next(1,5) /10m, ValueChange = rd.Next(3,10) /10m},
                new FundResult(){FCode = "3c",FundName = "KFMTFI-D",IsFavorite = true,FundDescription = "Krungsri Medium Term Fixed Income Divident Fund", FundType = "FIF & Gold", FundLogoUrl = "fund_logo", FundValue = rd.Next(14, 50), ValueChangePercent = rd.Next(1,5) /10m, ValueChange = rd.Next(3,10) /10m},
                new FundResult(){FCode = "4d",FundName = "Intouch Holdings PCL",IsFavorite = false,FundDescription = "InTouch Holdings is engages in the satellite, Internet, telecommunications, and media and advertising businesses.", FundType = "FIF & Gold", FundLogoUrl = "fund_logo2", FundValue = rd.Next(14, 50), ValueChangePercent = rd.Next(1,5) /10m, ValueChange = rd.Next(3,10) /10m},
                new FundResult(){FCode = "5e",FundName = "aCommerce",IsFavorite = true,FundDescription = "ACommerce is an e-Commerce enabler that provides end-to-end solutions for brands.", FundType = "FIF & Gold", FundLogoUrl = "fund_logo1", FundValue = rd.Next(14, 50), ValueChangePercent = rd.Next(1,5) /10m, ValueChange = rd.Next(3,10) /10m},
                new FundResult(){FCode = "7f",FundName = "Kuvera Capital Group",IsFavorite = false,FundDescription = "Kuvera Capital Group", FundType = "FIF & Gold", FundLogoUrl = "fund_logo", FundValue = rd.Next(14, 50), ValueChangePercent = rd.Next(1,5) /10m, ValueChange = rd.Next(3,10) /10m},
                new FundResult(){FCode = "8f",FundName = "Bangkok Bank",IsFavorite = false,FundDescription = "Since being founded in 1944, Bangkok Bank has enjoyed the proud heritage of being Thailand’s leading bank.", FundType = "FIF & Gold", FundLogoUrl = "fund_logo", FundValue = rd.Next(14, 50), ValueChangePercent = rd.Next(1,5) /10m, ValueChange = rd.Next(3,10) /10m},
                new FundResult(){FCode = "9f",FundName = "Devonshire Capital",IsFavorite = false,FundDescription = "Devonshire Capital is a privately owned independent Asian based merchant banking organisation.", FundType = "FIF & Gold", FundLogoUrl = "fund_logo", FundValue = rd.Next(14, 50), ValueChangePercent = rd.Next(1,5) /10m, ValueChange = rd.Next(3,10) /10m},
            };

            ListPeriod = new ObservableCollection<FilterPeriodModel>
            {
                new FilterPeriodModel(){Name = "1m",IsSelected = false},
                new FilterPeriodModel(){Name = "3m",IsSelected = false},
                new FilterPeriodModel(){Name = "6m",IsSelected = false},
                new FilterPeriodModel(){Name = "YTD",IsSelected = false},
                new FilterPeriodModel(){Name = "1y",IsSelected = false},
                new FilterPeriodModel(){Name = "3y",IsSelected = false},
                new FilterPeriodModel(){Name = "5y",IsSelected = false},
            };
        }

        #endregion

    }
}
