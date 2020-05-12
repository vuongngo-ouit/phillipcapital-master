using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PhillipCapital.Model;
using PhillipCapital.Model.Basket;
using PhillipCapital.Model.SearchFund;
using PhillipCapital.Utilities;
using Xamarin.Forms;

namespace PhillipCapital.Page.Summary
{
    class ReviewSummaryViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<BasketFundModel> _fundResult;

        #endregion

        #region Properties

        public ObservableCollection<BasketFundModel> ListFundResults
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

        public ReviewSummaryViewModel()
        {
            GetBasketFunds();
        }

        #endregion

        #region GetData

        private void GetBasketFunds()
        {
            var rd = new Random();
            ListFundResults = new ObservableCollection<BasketFundModel>
            {
                new BasketFundModel
                {
                    Amount = rd.Next(40000, 50000), Risk = rd.Next(6, 8), RiskText = "High Risk",
                    Color = "#E8756F", FundName = "PRINCIPAL APDI",
                    Description = "Principal Asia Pacific Dynamic Income Equity Fund",
                    OrderDate = DateTime.Now
                },
                new BasketFundModel
                {
                    FCode = "2b", Amount = rd.Next(40000, 50000), Risk = rd.Next(1, 2), RiskText = "Low Risk",
                    Color = "#26D1BD", FundName = "SCBRF",
                    Description = "Siam Commercial Bank Retirement Fund",
                    OrderDate = DateTime.Now
                },
                new BasketFundModel
                {
                    FCode = "3c", Amount = rd.Next(40000, 50000), Risk = rd.Next(2, 4), RiskText = "Medium Risk",
                    Color = "#FF8C00", FundName = "KFMTFI-D",
                    Description = "Krungsri Medium Term Fixed Income Divident Fund",
                    OrderDate = DateTime.Now
                },
                new BasketFundModel
                {
                    FCode = "4d", Amount = rd.Next(40000, 50000), Risk = rd.Next(6, 8), RiskText = "High Risk",
                    Color = "#E8756F", FundName = "Intouch Holdings PCL",
                    Description =
                        "InTouch Holdings is engages in the satellite, Internet, telecommunications, and media and advertising businesses.",
                    OrderDate = DateTime.Now
                },
                new BasketFundModel
                {
                    FCode = "5e", Amount = rd.Next(40000, 50000), Risk = rd.Next(6, 8), RiskText = "High Risk",
                    Color = "#E8756F", FundName = "aCommerce",
                    Description = "ACommerce is an e-Commerce enabler that provides end-to-end solutions for brands.",
                    OrderDate = DateTime.Now
                },
                new BasketFundModel
                {
                    FCode = "8f", Amount = rd.Next(40000, 50000), Risk = rd.Next(6, 8), RiskText = "High Risk",
                    Color = "#E8756F", FundName = "Bangkok Bank",
                    Description =
                        "Since being founded in 1944, Bangkok Bank has enjoyed the proud heritage of being Thailand’s leading bank.",
                    OrderDate = DateTime.Now
                },
                new BasketFundModel
                {
                    FCode = "9f", Amount = rd.Next(40000, 50000), Risk = rd.Next(6, 8), RiskText = "High Risk",
                    Color = "#E8756F", FundName = "Devonshire Capital",
                    Description =
                        "Devonshire Capital is a privately owned independent Asian based merchant banking organisation.",
                    OrderDate = DateTime.Now
                },

                new BasketFundModel
                {
                FCode = "9f", Amount = rd.Next(40000, 50000), Risk = rd.Next(6, 8), RiskText = "High Risk",
                Color = "#E8756F", FundName = "Devonshire Capital",
                Description =
                    "Devonshire Capital is a privately owned independent Asian based merchant banking organisation.",
                OrderDate = DateTime.Now
                },

                new BasketFundModel
                {
                    FCode = "9f", Amount = rd.Next(40000, 50000), Risk = rd.Next(6, 8), RiskText = "High Risk",
                    Color = "#E8756F", FundName = "Devonshire Capital",
                    Description =
                        "Devonshire Capital is a privately owned independent Asian based merchant banking organisation.",
                    OrderDate = DateTime.Now
                }
            };
        }

        #endregion
    }
}
