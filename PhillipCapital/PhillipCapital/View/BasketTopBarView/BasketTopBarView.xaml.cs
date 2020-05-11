using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.View.BasketTopBarView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasketTopBarView
    {
        public BasketTopBarView()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            BtnBack.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => { Navigation.PopAsync(); })
            });
        }
    }
}