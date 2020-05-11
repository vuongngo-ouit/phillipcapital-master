using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PhillipCapital.Model.SearchFund;
using PhillipCapital.Utilities;
using Xamarin.Forms;

namespace PhillipCapital.Page.SearchFund
{
    public class FilterViewModel: BaseViewModel
    {
        #region Fields

        private ObservableCollection<General> _generalFund;
        private ObservableCollection<Retirement> _retirementFund;
        private ObservableCollection<AMCs> _amcs;
        private int _generalHeight;
        private int _retirementHeight;
        private int _amcsHeight;
        public Command DoneCommand { get; }

        #endregion

        #region Properties

        public ObservableCollection<AMCs> ListAMCs
        {
            get => _amcs;
            set
            {
                _amcs = value;
                NotifyPropertyChanged();
            }
        }
        public int GeneralHeight
        {
            get => _generalHeight;
            set
            {
                _generalHeight = value;
                NotifyPropertyChanged();
            }
        }

        public int RetirementHeight
        {
            get => _retirementHeight;
            set
            {
                _retirementHeight = value;
                NotifyPropertyChanged();
            }
        }
        public int AMCsHeight
        {
            get => _amcsHeight;
            set
            {
                _amcsHeight = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Retirement> ListRetirement
        {
            get => _retirementFund;
            set
            {
                _retirementFund = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<General> ListGeneral
        {
            get => _generalFund;
            set
            {
                _generalFund = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Structure

        public FilterViewModel()
        {
            GetGeneralCategory();
            GetRetirementCategory();
            GetAMCs();
            DoneCommand = new Command(DonePress);
            GeneralHeight = ListGeneral.Count * 60;
            RetirementHeight = ListRetirement.Count * 60;
            AMCsHeight = ListAMCs.Count * 95;
        }

        #endregion

        #region Command

        private void DonePress()
        {
            Application.Current.MainPage.Navigation.PopModalAsync(true);
        }

        #endregion

        #region GetData

        private void GetAMCs()
        {
            Random rd = new Random();
            ListAMCs = new ObservableCollection<AMCs>()
            {
                new AMCs(){Id = 1,Name = "Aberdeen Standard Asset Management (Thailand) Limited",TotalManager = rd.Next(1,50)},
                new AMCs(){Id = 1,Name = "Krung Thai Asset Management Plc.",TotalManager = rd.Next(1,50)},
                new AMCs(){Id = 1,Name = "Land and Houses Fund Management Company Limited",TotalManager = rd.Next(1,50)},
                new AMCs(){Id = 1,Name = "Manulife Asset Management (Thailand) Co.",TotalManager = rd.Next(1,50)},
                new AMCs(){Id = 1,Name = "MFC Asset Management Plc.",TotalManager = rd.Next(1,50)},
                new AMCs(){Id = 1,Name = "One Asset Management Company Limited",TotalManager = rd.Next(1,50)},
                new AMCs(){Id = 1,Name = "Phatra Asset Management Co., Ltd.",TotalManager = rd.Next(1,50)},
                new AMCs(){Id = 1,Name = "Phillip Asset Management Company Limited",TotalManager = rd.Next(1,50)}
            };
        }

        private void GetRetirementCategory()
        {
            ListRetirement = new ObservableCollection<Retirement>
            {
                new Retirement(){Name = "Money Market RMF"},
                new Retirement(){Name = "Government Bond RMF"},
                new Retirement(){Name = "Fixed Income RMF"},
                new Retirement(){Name = "Mixed RMF"},
                new Retirement(){Name = "Equity RMF"},
                new Retirement(){Name = "Sector RMF"},
                new Retirement(){Name = "Gold RMF"}
            };
        }

        private void GetGeneralCategory()
        {
            ListGeneral = new ObservableCollection<General>
           {
               new General(){Name = "Money Market Fund"},
               new General(){Name = "Fixed Income Fund"},
               new General(){Name = "Mixed Fund"},
               new General(){Name = "Equity Fund"},
               new General(){Name = "Sector Fund"}
           };
        }

        #endregion

    }
}
