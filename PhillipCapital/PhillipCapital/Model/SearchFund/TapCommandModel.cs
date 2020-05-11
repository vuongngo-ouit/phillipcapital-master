using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using PhillipCapital.Helper;

namespace PhillipCapital.Model.SearchFund
{
    public class TopPick
    {
        #region Fields

        private bool _isSelect = false;

        #endregion

        #region Properties

        public bool IsSelected
        {
            get => _isSelect;
            set => _isSelect = value;
        }

        public string TextColor => _isSelect ? ResourceHelper.ColorMainBlue : ResourceHelper.ColorWhite;
        public string BgColor => _isSelect ? ResourceHelper.ColorWhite : ResourceHelper.ColorTransparent;
        public string Icon => _isSelect ? ResourceHelper.BlueStarIcon : ResourceHelper.WhiteStarIcon;
        #endregion
    }

    public class Favorite
    {
        #region Fields

        private bool _isSelect = false;

        #endregion

        #region Properties

        public bool IsSelected
        {
            get => _isSelect;
            set => _isSelect = value;
        }

        public string TextColor => _isSelect ? ResourceHelper.ColorMainBlue : ResourceHelper.ColorWhite;
        public string BgColor => _isSelect ? ResourceHelper.ColorWhite : ResourceHelper.ColorTransparent;
        public string Icon => _isSelect ? ResourceHelper.BlueHeartIcon : ResourceHelper.WhiteHeartIcon;
        #endregion
    }

    public class LTF
    {
        #region Fields

        private bool _isSelect = false;

        #endregion

        #region Properties

        public bool IsSelected
        {
            get => _isSelect;
            set => _isSelect = value;
        }

        public string TextColor => _isSelect ? ResourceHelper.ColorMainBlue : ResourceHelper.ColorWhite;
        public string BgColor => _isSelect ? ResourceHelper.ColorWhite : ResourceHelper.ColorTransparent;
        public string Icon => _isSelect ? ResourceHelper.BlueDollarIcon : ResourceHelper.WhiteDollarIcon;
        #endregion
    }
}
