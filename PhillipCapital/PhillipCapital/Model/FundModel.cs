namespace PhillipCapital.Model
{
    public class FundModel : BaseModel
    {
        #region Fields

        private string _fcode;
        private string _fmcode;
        private string _fundShortCode;
        private string _fundName;
        private string _fundThaiName;
        private int _fundTypeId;

        #endregion


        #region Properties

        public string FCode
        {
            get => _fcode;
            set
            {
                _fcode = value;
                OnPropertyChanged();
            }
        }

        public string FmCode
        {
            get => _fmcode;
            set
            {
                _fmcode = value;
                OnPropertyChanged();
            }
        }
        public string FundShortCode
        {
            get => _fundShortCode;
            set
            {
                _fundShortCode = value;
                OnPropertyChanged();
            }
        }
        public string FundName
        {
            get => _fundName;
            set
            {
                _fundName = value;
                OnPropertyChanged();
            }
        }
        public string FundThaiName
        {
            get => _fundThaiName;
            set
            {
                _fundThaiName = value;
                OnPropertyChanged();
            }
        }
        public int FundTypeId
        {
            get => _fundTypeId;
            set
            {
                _fundTypeId = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}
