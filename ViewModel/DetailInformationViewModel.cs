using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Assignment.Model;

namespace Test_Assignment.ViewModel
{
    class DetailInformationViewModel
    {
        public Currency SelectedCurrency { get; set; }

        public DetailInformationViewModel(Currency currency)
        {
            SelectedCurrency = currency;
        }
    }
}
