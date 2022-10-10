using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Assignment.Infrastructure;
using Test_Assignment.Model;
using Test_Assignment.View;

namespace Test_Assignment.ViewModel
{
    class SearchFormViewModel
    {
        public ObservableCollection<Currency> Currencies { get; set; }

        public Currency SelectedCurrency { get; set; }

        public SearchFormViewModel(ObservableCollection<Currency> currencies)
        {
            Currencies = currencies;
        }

        private DelegateCommand openDetailsCommand;

        public DelegateCommand OpenDetailsCommand
        {
            get
            {
                return openDetailsCommand ?? (openDetailsCommand = new DelegateCommand(OpenDetailsMethod));
            }
        }

        private void OpenDetailsMethod(object parametr)
        {
            DetailInformation win = new DetailInformation(SelectedCurrency);
            win.Owner = (parametr as MainWindow);
            win.ShowDialog();
        }
    }
}
