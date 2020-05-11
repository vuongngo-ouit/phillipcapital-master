using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhillipCapital.Page.SearchFund;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.View.Dashboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardCarouselItemView : ContentView
    {
        public DashboardCarouselItemView()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            BtnExplore.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => { Navigation.PushAsync(new SearchFundPage(), true); })
            });
        }
    }
}