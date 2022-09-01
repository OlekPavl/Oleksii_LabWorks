using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    interface IPrice
    {
        public int EuroPrice { get; set; }
        public int USDPrice { get; set; }
    }
}
