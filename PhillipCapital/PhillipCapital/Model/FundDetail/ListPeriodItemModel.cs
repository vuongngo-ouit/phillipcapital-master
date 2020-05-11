using PhillipCapital.Model.SearchFund;

namespace PhillipCapital.Model.FundDetail
{
    public class ListPeriodItemModel: FilterPeriodModel
    {
        #region Fields

        private decimal _percentChange;
        private string _backgroundColor;

        #endregion

        #region Peroperties

        public decimal PercentChange
        {
            get => _percentChange;
            set => _percentChange = value;
        }

        public string BackGroundColor
        {
            get => _backgroundColor;
            set => _backgroundColor = value;
        }

        #endregion

    }
}
