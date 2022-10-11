using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LabWork_5_4_DataSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=TECT_DATASETS_DB.MDF;Integrated Security=True;";
            //string connectionString = "Server=(localdb)\\mssqllocaldb;Database=TECT_DATASETS_DB.MDF;Trusted_Connection=True";


            DB_work mywrk = new DB_work(connectionString);
            mywrk.DB_conn();
            Console.WriteLine("Reading courses table");
            mywrk.Courses_Read("courses");
            Console.WriteLine();

            Console.WriteLine("Update courses table");
            mywrk.Courses_Update("courses", "course_id", "C13", "begin_date", "2014-01-06");

            Console.WriteLine("Reading courses table");
            mywrk.Courses_Read("courses");
            Console.WriteLine();

            Console.WriteLine("Update courses table by DataSet");
            mywrk.Courses_Update_ds("courses", "course_id", "C13", "begin_date", "2013-01-01");

            Console.WriteLine("Reading courses table");
            mywrk.Courses_Read("courses");
            Console.WriteLine();

            Console.WriteLine("Update courses table by Builder");
            mywrk.Courses_Update_bldr("courses", "course_id", "C13", "begin_date", "2010-01-01");

            Console.WriteLine("Reading courses table");
            mywrk.Courses_Read("courses");
            Console.WriteLine();

            Console.WriteLine("Insert  to courses table by Builder");
            string[] clmns = new string[] { "course_name", "contract", "facl_id" };
            string[] clmn_values = new string[] { "biology", "0", "" };
            mywrk.Courses_Insert_bldr("courses", "course_id", clmns, clmn_values);

            Console.WriteLine("Reading courses table");
            mywrk.Courses_Read("courses");
            Console.WriteLine();

            Console.WriteLine("Delete from courses table");

            Console.WriteLine("Write  key to delete: \r\n");
            string del_key = Console.ReadLine();
            mywrk.Courses_Delete("courses", "course_id", del_key);

            Console.WriteLine("Reading courses table");
            mywrk.Courses_Read("courses");


            Console.ReadKey();
        }
    }

}
