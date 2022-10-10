using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Test_Assignment.Model;

namespace Test_Assignment.ViewModel
{
    class ConvertCurrencyViewModel :INotifyPropertyChanged
    {
        public ObservableCollection<Currency> Currencies { get; set; }

        public Currency SelectedCurrencySum { get; set; }

        public Currency SelectedCurrencyResult { get; set; }

        private double sum;
        private double result;

        public double Sum 
        {
            get => sum;
            set
            {
                if (sum != value && SelectedCurrencyResult != null && SelectedCurrencySum != null)
                {
                    sum = value;
                    double tmp = sum / SelectedCurrencySum.PriceUSD;
                    Result = Math.Round(tmp * SelectedCurrencyResult.PriceUSD, 2);
                    OnPropertyChanged();
                }
            }
        }

        public double Result
        {
            get => result;
            set
            {
                if(result!=value)
                {
                    result = value;
                    OnPropertyChanged();
                }
            }
        }

        public ConvertCurrencyViewModel(ObservableCollection<Currency> currencies)
        {
            Currencies = currencies;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
