using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PhillipCapital.Model.Dashboard;
using PhillipCapital.Page.Portfolio;
using PhillipCapital.Utilities;
using Xamarin.Forms;

namespace PhillipCapital.Page.Dashboard
{
    public class DashboardViewModel : BaseViewModel
    {
        #region Fields

        private CurrentPortfolioValueModel _currentPortfolioValue;
        private ObservableCollection<FundTopPickModel> _lisTopPickFund;
        private ObservableCollection<NewFeedModel> _lisNewFeed;
        public Command OpenPortfolioPage { get; }

        #endregion

        #region Properties

        public ObservableCollection<NewFeedModel> ListNewFeed
        {
            get => _lisNewFeed;
            set
            {
                _lisNewFeed = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<FundTopPickModel> ListTopPickFund
        {
            get => _lisTopPickFund;
            set
            {
                _lisTopPickFund = value;
                NotifyPropertyChanged();
            }
        }

        public CurrentPortfolioValueModel CurrentPortfolioValue
        {
            get => _currentPortfolioValue;
            set
            {
                _currentPortfolioValue = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Structure

        public DashboardViewModel()
        {
            GetCurrentValue();
            GetNewFeedValue();
            OpenPortfolioPage = new Command(OpenPage);
        }

        private void OpenPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new PortfolioPage(), true);
        }

        #endregion

        #region GetData

        private void GetNewFeedValue()
        {
            ListNewFeed = new ObservableCollection<NewFeedModel>
            {
                new NewFeedModel(){Title = "Super Saving Funds Extra SSFX", ImageUrl = "newFeed3", Date = DateTime.Now.ToShortDateString()},
                new NewFeedModel(){Title = "New ATS 1,000 THB - Starts Jul 1 2018", ImageUrl = "newFeed2", Date = DateTime.Now.ToShortDateString()},
                new NewFeedModel(){Title = "Top 5 Thai Equity RMF - As of Feb 2020", ImageUrl = "newFeed", Date = DateTime.Now.ToShortDateString()}
            };
        }

        private void GetCurrentValue()
        {
            CurrentPortfolioValue = new CurrentPortfolioValueModel { Id = 1, Value = 205000, ValueChange = 25000, ValueChangePercent = 10.5 };
        }

        #endregion

    }
}
