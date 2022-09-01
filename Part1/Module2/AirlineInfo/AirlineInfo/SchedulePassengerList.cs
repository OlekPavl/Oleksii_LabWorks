using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    internal class SchedulePassengerList
    {
        int counter = 0;
        public FlightPassengerList[] schedulePassengersArray = new FlightPassengerList[0];

        public void AddPassengersToSchedulesPassengersList(FlightPassengerList flightPassengers)
        {
            counter++;
            FlightPassengerList[] tempArray = new FlightPassengerList[counter];

            for (int j = 0; j < schedulePassengersArray.Length; j++)
            {
                tempArray[j] = schedulePassengersArray[j];
            }
            schedulePassengersArray = tempArray;

            for (int j = 0; j < schedulePassengersArray.Length; j++)
            {
                if (schedulePassengersArray[j] == null)
                {
                    schedulePassengersArray[j] = flightPassengers;
                    //int number = GeneratePassportNumber();
                    //schedulePassengersArrayList[i].Passport = number;
                    //schedulePassengersArray[i].arrayPassenger[4] = number.ToString();
                    break;
                }
            }

            //int GeneratePassportNumber()
            //{
            //    Random random = new Random();

            //    int number;

            //    while (true)
            //    {
            //        number = random.Next(1000, 9999);
            //        bool status = false;
            //        foreach (var item in flightPassengersArrayList)
            //        {
            //            if (number == item.Passport)
            //            {
            //                status = true;
            //            }
            //        }
            //        if (status == false)
            //        {
            //            return number;
            //        }
            //    }

            //}

        }
        public void DisplaySchedulePassengerArray()
        {
            new FlightsBoard(schedulePassengersArray).DisplaySchedulePassengerList();
        }

    }
}
