using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.Page.Favorite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritePage : ContentPage
    {
        public FavoritePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}