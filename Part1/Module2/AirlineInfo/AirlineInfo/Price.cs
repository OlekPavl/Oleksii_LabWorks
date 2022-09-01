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
        public float EuroPrice { get; set; }
        public float USDPrice { get; set; } 

        public void PriceAutomaticalInitializer()
        {
            Random random = new Random();

            EuroPrice = random.Next(20, 100);
            arrayPrice[1] = EuroPrice.ToString();
            arrayPrice[2] = PriceCurrency.EUR.ToString();

            USDPrice = (float)(EuroPrice * 1.2);
            arrayPrice[3] = USDPrice.ToString();
            arrayPrice[4] = PriceCurrency.USD.ToString();

        }
    }
}
