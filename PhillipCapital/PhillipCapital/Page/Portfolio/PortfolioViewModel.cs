using PhillipCapital.Model.Portfolio;
using PhillipCapital.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PhillipCapital.Page.Portfolio
{
    public class PortfolioViewModel : BaseViewModel
    {
        #region Fields

        private PortfolioModel _portfolioValue;
        private ObservableCollection<Risk> _risk;
        private ObservableCollection<FundAsset> _fund;
        private ObservableCollection<Account> _account;
        public int ListAccountHeight { get; }
        public int ListVirAccountHeight { get; }

        #endregion

        #region Properties
        public ObservableCollection<Account> Account
        {
            get => _account;
            set
            {
                _account = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<FundAsset> Fund
        {
            get => _fund;
            set
            {
                _fund = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Risk> Risk
        {
            get => _risk;
            set
            {
                _risk = value;
                NotifyPropertyChanged();
            }
        }
        public PortfolioModel PortfolioValue
        {
            get => _portfolioValue;
            set
            {
                _portfolioValue = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Structure

        public PortfolioViewModel()
        {
            GetData();
            //ListAccountHeight = Account.Count * 50;
        }

        private void GetData()
        {
            Random rd = new Random();
            PortfolioValue = new PortfolioModel
            {
                PortfolioValue = 205000m,
                PercentChange = 10.5m,
                ValueChange = 20.5m,
                Cost = 167000m,
                UnrealizedReturn = 50000m,
                UnrealizedProfit = 107080m,
                PMoneyValue = 11203.00m,
                LastUpdate = DateTime.Now.ToShortTimeString()
            };

            Risk = new ObservableCollection<Risk>()
            {
                new Risk{Name = "High Risk",Value = 302.1254m},
                new Risk{Name = "Medium Risk",Value = 206.1254m},
                new Risk{Name = "Low Risk",Value = 152.1254m},
            };

            Fund = new ObservableCollection<FundAsset>()
            {
                new FundAsset
                {
                    FundName = "PRINCIPAL APDI", FundValue = rd.Next(141235,204569),FundType = "FIF & Gold", ValueChangePercent = rd.Next(2,6),ValueChange = rd.Next(3,7),FundLogoUrl = "fund_logo",
                    Units = rd.Next(12456,36214),Value =rd.Next(12456,36214),UnrealizedReturn = rd.Next(12456,36214), UnrealizedProfit = rd.Next(12456,36214), Cost = rd.Next(12456,36214)
                },
                new FundAsset
                {
                FundName = "SCBRF", FundValue = rd.Next(141235,204569),FundType = "FIF & Gold", ValueChangePercent = rd.Next(2,6),ValueChange = rd.Next(3,7),FundLogoUrl = "fund_logo1",
                Units = rd.Next(12456,36214),Value =rd.Next(12456,36214),UnrealizedReturn = rd.Next(12456,36214), UnrealizedProfit = rd.Next(12456,36214), Cost = rd.Next(12456,36214)
                },
                new FundAsset
                {
                    FundName = "KFMTFI-D", FundValue = rd.Next(141235,204569),FundType = "FIF & Gold", ValueChangePercent = rd.Next(2,6),ValueChange = rd.Next(3,7),FundLogoUrl = "fund_logo2",
                    Units = rd.Next(12456,36214),Value =rd.Next(12456,36214),UnrealizedReturn = rd.Next(12456,36214), UnrealizedProfit = rd.Next(12456,36214), Cost = rd.Next(12456,36214)
                },
                new FundAsset
                {
                    FundName = "PRINCIPAL APDI", FundValue = rd.Next(141235,204569),FundType = "FIF & Gold", ValueChangePercent = rd.Next(2,6),ValueChange = rd.Next(3,7),FundLogoUrl = "fund_logo",
                    Units = rd.Next(12456,36214),Value =rd.Next(12456,36214),UnrealizedReturn = rd.Next(12456,36214), UnrealizedProfit = rd.Next(12456,36214), Cost = rd.Next(12456,36214)
                }
            };

            Account = new ObservableCollection<Account>
            {
                new Account{Name = "long nguyen", VirtualAccount = new List<VirtualAccount>()
                {
                    new VirtualAccount{Name="long virtual 1"},
                    new VirtualAccount{Name="long virtual 1"}
                }},
                new Account{Name="long 021544"},
                new Account{Name= "3215654"},
                new Account{Name= "abc4587"},
                new Account{Name= "3215kiyh"}
            };
        }

        #endregion
    }
}
