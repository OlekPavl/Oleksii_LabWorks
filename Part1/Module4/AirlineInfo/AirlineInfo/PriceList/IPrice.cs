using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    interface IPrice
    {
        public float EuroPrice { get; set; }
        public float USDPrice { get; set; }
    }
}
