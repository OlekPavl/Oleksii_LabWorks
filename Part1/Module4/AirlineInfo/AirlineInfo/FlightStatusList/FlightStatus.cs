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
    
    public delegate void FlightStatusHandler(int numb);


    class FlightStatus
    {
        public string[] arrayFlightStatus = new string[9];
        public int? FlightNumber { get; set; }
        FlightInformation flight;

        public FlightStatus()
        {

        }
        public FlightStatus(FlightInformation flight)
        {
            this.flight = flight;
            FlightNumber = flight.FlightNumber;
            arrayFlightStatus[0] = FlightNumber.ToString();
            FlightStatusAutomaticalInitializer();
        }

        public int Gate { get; set; }
        public CheckInStatus CheckIn { get; set; }
        public GateClosedStatus GateClosed { get; set; }
        public CancelledStatus Cancelled { get; set; }
        public InFlightStatus InFlight { get; set; }

        public DateTime? departedAt;
        public DateTime? DepartedAt
        {
            get
            {
                return departedAt;
            }
            set
            {
                departedAt = value;
            }
        }

        public DateTime? expectedAt;
        public DateTime? ExpectedAt
        {
            get
            {
                return expectedAt;
            }
            set
            {
                expectedAt = value;
            }
        }

        public DateTime? arrivedAt;
        public DateTime? ArrivedAt
        {
            get
            {
                return arrivedAt;
            }
            set
            {
                arrivedAt = value;
            }
        }

        DateTime? tempDeprAt;
        DateTime? tempExpectedAt;
        DateTime? tempArrAt;

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
        public void FlightStatusAutomaticalInitializer()
        {

            Random random = new Random();
            Gate = random.Next(1, 20);
            arrayFlightStatus[1] = Gate.ToString();

            TimeSpan timeSpan = TimeSpan.FromHours(5);


            //CancelledStatus[] cancelledArray = new CancelledStatus[] { CancelledStatus.Cancelled, CancelledStatus.NotCancelled };
            Cancelled = CancelledStatus.NotCancelled;
            arrayFlightStatus[4] = Cancelled.ToString();

            DepartedAt = null;
            arrayFlightStatus[6] = departedAt.ToString();
            ExpectedAt = null;
            arrayFlightStatus[7] = expectedAt.ToString();
            ArrivedAt = null;
            arrayFlightStatus[8] = arrivedAt.ToString();

            GetRandomDates(out tempDeprAt, out tempExpectedAt, out tempArrAt);

            if (departedAt != null)
            {
                InFlight = InFlightStatus.InFlight;
                arrayFlightStatus[5] = InFlight.ToString();
            }
            else
            {
                InFlight = InFlightStatus.OnGround;
                arrayFlightStatus[5] = InFlight.ToString();
            }

            if (InFlight == InFlightStatus.InFlight)
            {
                GateClosed = GateClosedStatus.Closed;
                arrayFlightStatus[3] = GateClosed.ToString();
            }
            else
            {
                GateClosed = GateClosedStatus.NotClosed;
                arrayFlightStatus[3] = GateClosed.ToString();
            }

            if (InFlight == InFlightStatus.InFlight)
            {
                CheckIn = CheckInStatus.Finished;
                arrayFlightStatus[2] = CheckIn.ToString();
            }
            else
            {
                CheckIn = CheckInStatus.NotFinished;
                arrayFlightStatus[2] = CheckIn.ToString();
            }

            void GetRandomDates(out DateTime? tempDeprAt, out DateTime? tempExpAt, out DateTime? tempArrAt)
            {
                Random random = new Random();

                tempDeprAt = flight.DepartureDateTime + TimeSpan.FromSeconds(random.Next(0, 60));
                tempExpAt = tempDeprAt + TimeSpan.FromMinutes(random.Next(35, 55));
                tempArrAt = tempExpAt + TimeSpan.FromMinutes(random.Next(0, 5));

            }

        }
        
        public event FlightStatusHandler? Notify;
        public void CheckUpdateStatus()
        {
            if (departedAt == null)
            {
                if (tempDeprAt <= DateTime.Now)
                {
                    DepartedAt = tempDeprAt;
                    arrayFlightStatus[6] = DepartedAt.ToString();
                    ExpectedAt = tempExpectedAt;
                    arrayFlightStatus[7] = ExpectedAt.ToString();
                    CheckIn = CheckInStatus.Finished;
                    arrayFlightStatus[2] = CheckIn.ToString();
                    GateClosed = GateClosedStatus.Closed;
                    arrayFlightStatus[3] = GateClosed.ToString();
                    InFlight = InFlightStatus.InFlight;
                    arrayFlightStatus[5] = InFlight.ToString();
                    int number = Convert.ToInt32(arrayFlightStatus[0]);
                    Notify?.Invoke(number);
                }                                
            }
            if (expectedAt != null && arrivedAt == null)
            {
                if (tempArrAt <= DateTime.Now)
                {
                    ArrivedAt = tempArrAt;
                    arrayFlightStatus[8] = ArrivedAt.ToString();
                }
            }

        }


    }
}
