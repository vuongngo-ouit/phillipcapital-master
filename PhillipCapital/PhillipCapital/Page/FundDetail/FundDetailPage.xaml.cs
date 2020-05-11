using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.Page.FundDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FundDetailPage : ContentPage
    {
        public FundDetailPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
        }
    }
}