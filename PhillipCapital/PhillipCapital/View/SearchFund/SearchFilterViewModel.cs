
using PhillipCapital.Model.SearchFund;
using PhillipCapital.Utilities;
using Xamarin.Forms;
using Favorite = PhillipCapital.Model.SearchFund.Favorite;

namespace PhillipCapital.View.SearchFund
{
    public class SearchFilterViewModel : BaseViewModel
    {
        #region Fields

        public Command SelectTopPick { get; }
        public Command SelectLTF { get; }
        public Command SelectFavorite { get; }
        private TopPick _topPickModel = new TopPick();
        private LTF _ltfModel = new LTF();
        private Model.SearchFund.Favorite _favorite = new Model.SearchFund.Favorite();

        #endregion

        #region Properties

        public LTF LTFModel
        {
            get => _ltfModel;
            set
            {
                _ltfModel = value;
                NotifyPropertyChanged();
            }
        }

        public Model.SearchFund.Favorite FavoriteModel
        {
            get => _favorite;
            set
            {
                _favorite = value;
                NotifyPropertyChanged();
            }
        }
        public TopPick TopPickModel
        {
            get => _topPickModel;
            set
            {
                _topPickModel = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        public SearchFilterViewModel()
        {
            SelectTopPick = new Command(SelectedTopPick);
            SelectFavorite = new Command(SelectedFavorite);
            SelectLTF = new Command(SelectedLTF);
        }

        private void SelectedLTF(object obj)
        {
            LTFModel.IsSelected = !LTFModel.IsSelected;
            NotifyPropertyChanged(nameof(LTFModel));
        }

        private void SelectedFavorite(object obj)
        {
            FavoriteModel.IsSelected = !FavoriteModel.IsSelected;
            NotifyPropertyChanged(nameof(FavoriteModel));
        }

        private void SelectedTopPick()
        {
            TopPickModel.IsSelected = !TopPickModel.IsSelected;
            NotifyPropertyChanged(nameof(TopPickModel));
        }
    }
}
