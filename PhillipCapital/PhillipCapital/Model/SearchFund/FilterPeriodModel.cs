using PhillipCapital.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhillipCapital.Model.SearchFund
{
    public class FilterPeriodModel
    {
        #region Fields

        private bool _isSelect = false;
        private string _name;

        #endregion

        #region Properties

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public bool IsSelected
        {
            get => _isSelect;
            set => _isSelect = value;
        }
        public string TextColor => _isSelect ? ResourceHelper.ColorWhite : ResourceHelper.ColorGrey;
        public string BgColor => _isSelect ? ResourceHelper.ColorMainBlue : ResourceHelper.ColorWhite;
        #endregion
    }
}
