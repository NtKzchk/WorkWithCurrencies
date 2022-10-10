using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Test_Assignment.Model;
using Test_Assignment.ViewModel;

namespace Test_Assignment.View
{
    /// <summary>
    /// Логика взаимодействия для ConvertCurrency.xaml
    /// </summary>
    public partial class ConvertCurrency : Window
    {
        public ConvertCurrency()
        {
            InitializeComponent();
        }

        public ConvertCurrency(ObservableCollection<Currency> currencies)
        {
            InitializeComponent();
            DataContext = new ConvertCurrencyViewModel(currencies);
        }
    }
}
