using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.Page.Summary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewSummary : ContentPage
    {
        public ReviewSummary()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}