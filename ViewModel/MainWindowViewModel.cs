using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Test_Assignment.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Test_Assignment.Infrastructure;
using Test_Assignment.View;

namespace Test_Assignment.ViewModel
{
    class MainWindowViewModel
    {
        public ObservableCollection<Currency> AllCurrencies { get; set; }
        public ObservableCollection<Currency> TopCurrencies { get; set; } = new ObservableCollection<Currency>();

        public Currency SelectedCurrency { get; set; }

        public MainWindowViewModel()
        {
            string url = "http://api.coincap.io/v2/assets";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
                response = response.Remove(0, 8);
                response = response.Remove(response.LastIndexOf(","), response.LastIndexOf("}") - response.LastIndexOf(",") + 1);
                AllCurrencies = JsonConvert.DeserializeObject<ObservableCollection<Currency>>(response);
            }
            foreach (var currency in AllCurrencies)
            {
                if (currency.Rank == 11)
                    break;
                TopCurrencies.Add(currency);
            }
        }

        private DelegateCommand openDetailsCommand;
        private DelegateCommand openSearchCommand;
        private DelegateCommand openConvertCommand;

        public DelegateCommand OpenDetailsCommand
        {
            get
            {
                return openDetailsCommand ?? (openDetailsCommand = new DelegateCommand(OpenDetailsMethod));
            }
        }

        public DelegateCommand OpenSearchCommand
        {
            get
            {
                return openSearchCommand ?? (openSearchCommand = new DelegateCommand(OpenSearchMethod));
            }
        }

        public DelegateCommand OpenConvertCommand
        {
            get
            {
                return openConvertCommand ?? (openConvertCommand = new DelegateCommand(OpenConvertMethod));
            }
        }

        private void OpenDetailsMethod(object parametr)
        {
            DetailInformation win = new DetailInformation(SelectedCurrency);
            win.Owner = (parametr as MainWindow);
            win.ShowDialog();
        }

        private void OpenSearchMethod(object parametr)
        {
            SearchForm win = new SearchForm(AllCurrencies);
            win.Owner = (parametr as MainWindow);
            win.ShowDialog();
        }

        private void OpenConvertMethod(object parametr)
        {
            ConvertCurrency win = new ConvertCurrency(AllCurrencies);
            win.Owner = (parametr as MainWindow);
            win.ShowDialog();
        }
    }
}
