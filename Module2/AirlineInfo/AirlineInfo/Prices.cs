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
    
    class Prices : IPrice
    {
        public string[] arrayPriceList = new string[4];
        public Prices()
        {
            PriceInitializer();
        }
        public double Price { get; set; }
        public PriceCurrency Currency { get; set; }

        public void PriceInitializer()
        {
            Console.Write("Enter price: ");
            Price = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                bool result = false;
                Console.Write("Enter currency (1 - eur / 2 - usd): ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Currency = PriceCurrency.EUR;
                        result = true;
                        break;
                    case 2:
                        Currency = PriceCurrency.USD;
                        result = true;
                        break;
                    default:
                        Console.WriteLine("There is no such currency");
                        break;
                }

                if (result == true)
                {
                    break;
                }
            }


        }
    }
}
