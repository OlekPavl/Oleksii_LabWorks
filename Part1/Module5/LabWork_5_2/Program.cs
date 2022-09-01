using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
//using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Hello_Serialization_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instance of Student class
            // Initialize its properties
            // Call methods for serialization and deserialization

            Student student = new Student();
            student.SetAddress("Dortmund", "125");

            BinaryFrm(student);
            XmlFrm(student);



            Console.ReadKey();
        }

        // Impement BinaryFrm(Student p) method to serialize and deserialize p
        // Define path for file
        // Implement BinaryFormatter object creation and p serialization  in using block for FileStream object

        // Implement BinaryFormatter object creation and  deserialization  in using block for FileStream object
        // Write deserialization result to console
        public static void BinaryFrm(Student p)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("students.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, p);
                Console.WriteLine("Object serialised");
            }

            using (FileStream fs = new FileStream("students.dat", FileMode.OpenOrCreate))
            {
                Student newStudent = (Student)formatter.Deserialize(fs);

                Console.WriteLine("Object deserialised");
                Console.WriteLine($"Name: {newStudent.Address} - Code: {newStudent.Code}");
            }

            Console.ReadLine();
        }


        // Impement SoapFrm(Student p) method to serialize and deserialize p
        //public static void SoapFrm(Student p)
        // Define path for file
        // Implement SoapFormatter object creation and p serialization  in using block for FileStream object

        // Implement SoapFormatter object creation and  deserialization  in using block for FileStream object
        // Write deserialization result to console
        //{
        //    SoapFormatter formatter = new SoapFormatter();

        //    using (FileStream fs = new FileStream("students.dat", FileMode.OpenOrCreate))
        //    {
        //        formatter.Serialize(fs, p);
        //        Console.WriteLine("Object serialised");
        //    }

        //    using (FileStream fs = new FileStream("students.dat", FileMode.OpenOrCreate))
        //    {
        //        Student newStudent = (Student)formatter.Deserialize(fs);

        //        Console.WriteLine("Object deserialised");
        //        Console.WriteLine($"Name: {newStudent.Address} - Code: {newStudent.Code}");
        //    }

        //    Console.ReadLine();
        //}


        // Impement XmlFrm(Student p) method to serialize and deserialize p
        // Define path for file
        // Create XmlSerializer serializer typeof Student       
        // Implement  p serialization  in using block for FileStream object

        // Create XmlSerializer deserializer typeof Student 
        // Implement   deserialization  in using block for FileStream object
        // Write deserialization result to console
        public static void XmlFrm(Student p)
        {
            XmlSerializer xmlSerializer = new XmlSerializer (typeof(Student));

            using (FileStream fs = new FileStream("students.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, p);
                Console.WriteLine("Object has been serialized");
            }

            using (FileStream fs = new FileStream("students.xml", FileMode.OpenOrCreate))
            {
                Student? newStudent = xmlSerializer.Deserialize(fs) as Student;
                Console.WriteLine("Object deserialised");
                Console.WriteLine($"Name: {newStudent.Address} - Code: {newStudent.Code}");
            }

            Console.ReadLine();
        }




    }
}
