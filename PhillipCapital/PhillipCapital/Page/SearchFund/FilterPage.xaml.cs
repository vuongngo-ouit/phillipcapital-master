using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhillipCapital.Page.SearchFund
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilterPage : ContentPage
    {
        private bool IsFundCategoryExpand = false;
        private bool IsAMCsExpand = false;
        public FilterPage()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            ExpandFundCategory.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    StkFundCategory.IsVisible = !IsFundCategoryExpand;
                    IsFundCategoryExpand = !IsFundCategoryExpand;
                })
            });

            ExpandAMCs.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    ListAMCs.IsVisible = !IsAMCsExpand;
                    IsAMCsExpand = !IsAMCsExpand;
                })
            });
        }
    }
}