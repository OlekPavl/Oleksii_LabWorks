using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Hello_Serialization_stud
{

    [Serializable] //Required by BinaryFormatter and SoapFormatter  
    public class Student  //XMLSerializer needs the public class
    {
        public string Address { get; set; }
        public string Code { get; set; }


        public int field3 = 3;
        
        [System.Xml.Serialization.XmlIgnore]   //Ignore in Xml Serialization          
        public int field1 = 1;                 //Public fields are serialize by the three formatters  

        [NonSerialized] //Thield will not be serialized
        public int field2 = 2;



        //These fields will not be serialized by XmlSerialization
        [System.Xml.Serialization.XmlIgnore]
        public int field4 = 4;

        [System.Xml.Serialization.XmlIgnore]
        public int field5 = 5;

        // Create SetAddress(string address, string code) method
        public void SetAddress(string address, string code)
        {
            Address = address;
            Code = code;
        }

        // Override ToString() method
        public override string ToString()
        {
            return String.Concat(Address, " ", Code);
        }

        
        

    }

}
