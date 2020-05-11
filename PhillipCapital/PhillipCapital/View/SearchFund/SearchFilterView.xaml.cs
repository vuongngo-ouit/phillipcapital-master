using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhillipCapital.Page.SearchFund;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.View.SearchFund
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchFilterView : ContentView
    {
        public SearchFilterView()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            BtnFilter.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => { Navigation.PushModalAsync(new FilterPage(), true); })
            });
        }
    }
}