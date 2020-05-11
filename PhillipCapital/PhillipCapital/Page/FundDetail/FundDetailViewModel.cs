using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PhillipCapital.Helper;
using PhillipCapital.Model.FundDetail;
using PhillipCapital.Utilities;
using Xamarin.Forms;

namespace PhillipCapital.Page.FundDetail
{
    public class FundDetailViewModel : BaseViewModel
    {
        #region Fields

        private FundDetailModel _fundDetail;
        private FundInformationModel _fundInformation;
        private ObservableCollection<ListPeriodItemModel> _listPeriod;
        private bool _isPerformanceSelected = true;
        private bool _isFInformationSelected = false;
        private string _performanceTextColor = ResourceHelper.ColorLightBlue;
        private string _fInformationTextColor;
        private Command _performanceCommand;
        private Command _fInformationCommand;
        public List<FundDetailModel.Person> Data { get; set; }

        #endregion

        #region Properties

        public Command PerformanceCommand
        {
            get => _performanceCommand;
            set
            {
                _performanceCommand = value;
                NotifyPropertyChanged();
            }
        }
        public Command FInformationCommand
        {
            get => _fInformationCommand;
            set
            {
                _fInformationCommand = value;
                NotifyPropertyChanged();
            }
        }
        public bool IsPerformanceSelected
        {
            get => _isPerformanceSelected;
            set
            {
                _isPerformanceSelected = value;
                NotifyPropertyChanged();
            }
        }
        public bool IsFInformationSelected
        {
            get => _isFInformationSelected;
            set
            {
                _isFInformationSelected = value;
                NotifyPropertyChanged();
            }
        }
        public string PerformanceTextColor
        {
            get => _performanceTextColor;
            set
            {
                _performanceTextColor = value;
                NotifyPropertyChanged();
            }
        }
        public string FInformationTextColor
        {
            get => _fInformationTextColor;
            set
            {
                _fInformationTextColor = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<ListPeriodItemModel> ListPeriod
        {
            get => _listPeriod;
            set
            {
                _listPeriod = value;
                NotifyPropertyChanged();
            }
        }
        public FundInformationModel FundInformation
        {
            get => _fundInformation;
            set
            {
                _fundInformation = value;
                NotifyPropertyChanged();
            }
        }
        public FundDetailModel FundDetail
        {
            get => _fundDetail;
            set
            {
                _fundDetail = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Structure

        public FundDetailViewModel()
        {
            GetData();
            PerformanceCommand = new Command(PerformanceTap);
            FInformationCommand = new Command(FInformationTap);
        }

        private void FInformationTap(object obj)
        {
            IsFInformationSelected = true;
            IsPerformanceSelected = !IsFInformationSelected;
            FInformationTextColor = ResourceHelper.ColorLightBlue;
            PerformanceTextColor = ResourceHelper.ColorGrey;
        }

        private void PerformanceTap(object obj)
        {
            IsPerformanceSelected = true;
            IsFInformationSelected = !IsPerformanceSelected;
            PerformanceTextColor = ResourceHelper.ColorLightBlue;
            FInformationTextColor = ResourceHelper.ColorGrey;
        }

        #endregion

        #region GetData

        private void GetData()
        {
            FundDetail = new FundDetailModel
            {
                FundName = "Principal APDI",
                FundDescription = "Principal Asia Pacific Dynamic",
                FundValue = 124 / 3m,
                Buy = 126 / 3m,
                Sell = 122 / 3m,
                ValueChange = 22,
                ValueChangePercent = 2,
                RiskLevel = 6,
                RiskColor = "#ff5208",
                RiskText = "Medium-High Risk",
                NavDate = DateTime.Now.ToShortDateString()
            };

            FundInformation = new FundInformationModel
            {
                FundType = "FIF - Equity Fund",
                FundTypeDesc = "Foreign Investment Fund",
                FundOwner = "Principal Asset Management Company Limited",
                RegisteredDate = DateTime.Now.ToShortDateString(),
                MinimumInvestment = 5000,
                Minimum1stInvestment = 5000,
                DayOfRedemption = "T + 2",
                Top10Holding = 12345,
                FirstPurchase = 5000,
                NextPurchase = 5000,
                MinimumSellingPrice = 5000,
                ATS = DateTime.Now.ToShortTimeString(),
                PMoney = DateTime.Now.ToShortTimeString(),
                SalesClosingTime = DateTime.Now.ToShortTimeString(),
                FrontEndPurchaseFee = 10,
                BackEndSalesFee = 10,
                BrokerageFee = 10,
                ManagementFee = 10,
                TotalExpenseRatio = 10
            };

            ListPeriod = new ObservableCollection<ListPeriodItemModel>()
            {
                new ListPeriodItemModel(){Name = "1m",PercentChange = 1.03m,BackGroundColor = "#fafafa"},
                new ListPeriodItemModel(){Name = "3m",PercentChange = 1.03m,BackGroundColor = "#fafafa"},
                new ListPeriodItemModel(){Name = "6m",PercentChange = 1.03m,BackGroundColor = "#fafafa"},
                new ListPeriodItemModel(){Name = "YTD",PercentChange = 1.03m,BackGroundColor = "#fafafa"},
                new ListPeriodItemModel(){Name = "1y",PercentChange = 1.03m,BackGroundColor = "#fafafa"},
                new ListPeriodItemModel(){Name = "3y",PercentChange = 1.03m,BackGroundColor = "#c0c0c0"},
                new ListPeriodItemModel(){Name = "5y",PercentChange = 1.03m,BackGroundColor = "#c0c0c0"}
            };

            Data = new List<FundDetailModel.Person>()
            {
                new FundDetailModel.Person { Name = "David", Height = 30 },
                new FundDetailModel.Person { Name = "Michael", Height = 100 },
                new FundDetailModel.Person { Name = "Steve", Height = 20 },
                new FundDetailModel.Person { Name = "Joel", Height = 50 }
            };
        }

        #endregion

    }
}
