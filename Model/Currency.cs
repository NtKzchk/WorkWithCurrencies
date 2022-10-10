using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assignment.Model
{
    public class Currency
    {
        public string Id { get; set; }
        public int Rank { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double Supply { get; set; }
        public double? MaxSupply { get; set; }
        public double? MarketCapUSD { get; set; }
        public double PriceUSD { get; set; }
        public double? VolumeUSD24Hr { get; set; }
        public string Explorer { get; set; }
    }
}
