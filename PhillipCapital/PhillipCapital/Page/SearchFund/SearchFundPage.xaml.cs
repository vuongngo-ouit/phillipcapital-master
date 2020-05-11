using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhillipCapital.Page.FundDetail;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ItemTappedEventArgs = Syncfusion.ListView.XForms.ItemTappedEventArgs;

namespace PhillipCapital.Page.SearchFund
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchFundPage : ContentPage
    {
        public SearchFundPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void SfListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new FundDetailPage(), true);
        }
    }
}