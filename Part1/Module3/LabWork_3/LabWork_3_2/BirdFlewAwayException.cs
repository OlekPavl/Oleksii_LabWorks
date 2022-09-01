using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3_2
{
    //Create the BirdFlewAwayException class, derived from ApplicationException  with two properties  
    class BirdFlewAwayException : ApplicationException
    {
        //When
        public DateTime When { get; set; }

        //Why
        public string Why { get; set; }

        //Create constructors
        public BirdFlewAwayException() { }

        public BirdFlewAwayException(string message, string cause, DateTime time) : base(message)
        {
            Why = cause;
            When = time;
        }
    }

}
