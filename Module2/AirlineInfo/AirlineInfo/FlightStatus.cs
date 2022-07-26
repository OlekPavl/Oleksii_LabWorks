using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    enum CheckInStatus
    {
        Finished,
        NotFinished
    }
    enum GateClosedStatus
    {
        Closed,
        NotClosed
    }

    enum InFlightStatus
    {
        InFlight,
        OnGround
    }

    enum CancelledStatus
    {
        Cancelled,
        NotCancelled
    }

    class FlightStatus
    {
        public string[] arrayFlightStatus = new string[9];
        public int FlightNumber { get; set; }

        public FlightStatus(FlightInformation flight)
        {
            FlightNumber = flight.FlightNumber;
            arrayFlightStatus[0] = FlightNumber.ToString();
            FlightStatusInitializer();
        }

        public int Gate { get; set; }
        public CheckInStatus CheckIn { get; set; }
        public GateClosedStatus GateClosed { get; set; }
        public InFlightStatus InFlight { get; set; }
        public CancelledStatus Cancelled { get; set; }
        public DateTime? DepartedAt { get; set; }
        public DateTime? ExpectedAt { get; set; }
        public DateTime? ArrivedAt { get; set; }

        public void FlightStatusInitializer()
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
                    arrayFlightStatus[1] = Gate.ToString();
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
                        CheckIn = CheckInStatus.Finished;
                        result = true;
                        break;
                    case 2:
                        CheckIn = CheckInStatus.NotFinished;
                        result = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }

                if (result == true)
                {
                    arrayFlightStatus[2] = CheckIn.ToString();
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
                        GateClosed = GateClosedStatus.Closed;
                        result = true;
                        break;
                    case 2:
                        GateClosed = GateClosedStatus.NotClosed;
                        result = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }

                if (result == true)
                {
                    arrayFlightStatus[3] = GateClosed.ToString();
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
                        InFlight = InFlightStatus.InFlight;
                        result = true;
                        break;
                    case 2:
                        InFlight = InFlightStatus.OnGround;
                        result = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }

                if (result == true)
                {
                    arrayFlightStatus[4] = InFlight.ToString();
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
                        Cancelled = CancelledStatus.Cancelled;
                        result = true;
                        break;
                    case 2:
                        Cancelled = CancelledStatus.NotCancelled;
                        result = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        break;
                }

                if (result == true)
                {
                    arrayFlightStatus[5] = Cancelled.ToString();
                    break;
                }
            }

            try
            {
                Console.Write("Departured at (dd.mm.yy hh:mm): ");
                DepartedAt = Convert.ToDateTime(Console.ReadLine());
                arrayFlightStatus[6] = DepartedAt.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.Write("Expected at (dd.mm.yy hh:mm): ");
                ExpectedAt = Convert.ToDateTime(Console.ReadLine());
                arrayFlightStatus[7] = ExpectedAt.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.Write("Arrived at (dd.mm.yy hh:mm): ");
                ArrivedAt = Convert.ToDateTime(Console.ReadLine());
                arrayFlightStatus[8] = ArrivedAt.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
