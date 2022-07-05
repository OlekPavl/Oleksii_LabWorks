using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportPanel
{
    class FlightStatus
    {
        public FlightStatus()
        {
            FlightStatusInitialiser();
        }
        
        public int Gate { get; set; }
        public bool CheckIn { get; set; }
        public bool GateClosed { get; set; }
        public bool InFlight { get; set; }
        public bool Cancelled { get; set; }
        public DateTime? DepartedAt { get; set; }
        public DateTime? ExpectedAt { get; set; }
        public DateTime? ArrivedAt { get; set; }

        public void FlightStatusInitialiser()
        {
            while (true)
            {
                bool result = false;
                Console.Write("Number of gate (1 - 10): ");
                Gate = Convert.ToInt32(Console.ReadLine());
                switch (Gate)
                {
                    case 1:
                        result = true;
                        break;
                    case 2:
                        result = true;
                        break;
                    case 3:
                        result = true;
                        break;
                    case 4:
                        result = true;
                        break;
                    case 5:
                        result = true;
                        break;
                    case 6:
                        result = true;
                        break;
                    case 7:
                        result = true;
                        break;
                    case 8:
                        result = true;
                        break;
                    case 9:
                        result = true;
                        break;
                    case 10:
                        result = true;
                        break;
                    default:
                        Console.WriteLine("Gate does not exist");
                        break;
                }

                if (result == true)
                {
                    break;
                }
            }
            while (true)
            {
                bool result = false;
                Console.Write("Check-In (1 - yes / 2 - no): ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        CheckIn = true;
                        result = true;
                        break;
                    case 2:
                        CheckIn = false;
                        result = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }

                if (result == true)
                {
                    break;
                }
            }
            while (true)
            {
                bool result = false;
                Console.Write("GateClosed (1 - yes / 2 - no): ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        GateClosed = true;
                        result = true;
                        break;
                    case 2:
                        GateClosed = false;
                        result = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }

                if (result == true)
                {
                    break;
                }
            }
            while (true)
            {
                bool result = false;
                Console.Write("In Flight? (1 - yes / 2 - no): ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        InFlight = true;
                        result = true;
                        break;
                    case 2:
                        InFlight = false;
                        result = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }

                if (result == true)
                {
                    break;
                }
            }
            while (true)
            {
                bool result = false;
                Console.Write("Cancelled? (1 - yes / 2 - no): ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Cancelled = true;
                        result = true;
                        break;
                    case 2:
                        Cancelled = false;
                        result = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }

                if (result == true)
                {
                    break;
                }
            }

            DepartedAt = null;
            ExpectedAt = null;
            ArrivedAt = null;
        }


    }
}
