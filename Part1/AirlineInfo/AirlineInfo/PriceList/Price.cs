using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    enum PriceCurrency
    {
        EUR,
        USD
    }
    
    class Price : IPrice
    {
        public string[] arrayPrice = new string[5];

        public int? FlightNumber { get; set; }
        FlightInformation flight;
        public Price(FlightInformation flight)
        {
            this.flight = flight;
            FlightNumber = flight.FlightNumber;
            arrayPrice[0] = FlightNumber.ToString();
            PriceAutomaticalInitializer();
        }
        public Price()
        {
            EmptyPriceAutomaticalInitializer();
        }
        public int? EuroPrice { get; set; }
        public int? USDPrice { get; set; } 

        public void PriceAutomaticalInitializer()
        {
            Random random = new Random();

            EuroPrice = random.Next(20, 100);
            arrayPrice[1] = EuroPrice.ToString();
            arrayPrice[2] = PriceCurrency.EUR.ToString();

            USDPrice = (int)(EuroPrice * 1.2);
            arrayPrice[3] = USDPrice.ToString();
            arrayPrice[4] = PriceCurrency.USD.ToString();

        }
        public void EmptyPriceAutomaticalInitializer()
        {
            FlightNumber = null;
            arrayPrice[0] = null;

            EuroPrice = null;
            arrayPrice[1] = null;

            arrayPrice[2] = null;

            USDPrice = null;
            arrayPrice[3] = null;
            arrayPrice[4] = null;

        }
    }
}
