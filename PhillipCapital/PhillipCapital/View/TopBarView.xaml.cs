using Syncfusion.DataSource.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopBarView : ContentView
    {
        public TopBarView()
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