using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LabWork_5_4_DataSets
{
    //string connectionString = @"Data Source=localhost;Initial Catalog=TECT_DATASETS_DB.MDF;Integrated Security=True;";

    //// Создание подключения
    //SqlConnection connection = new SqlConnection(connectionString);
    //try
    //{
    //    // Открываем подключение
    //    connection.Open();
    //    Console.WriteLine("Подключение открыто");
    //}
    //catch (SqlException ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=TECT_DATASETS_DB.MDF;Integrated Security=True;";
            //string connectionString = "Server=(localdb)\\mssqllocaldb;Database=TECT_DATASETS_DB.MDF;Trusted_Connection=True";


            // update connection string for current LocalDB instance 
            Common_db commonDb = new Common_db(connectionString);
            DataTable dt = new DataTable("courses");
            //bool result = commonDb.MyTable_delete(dt, "course_id", "C04");
            //bool result = commonDb.MyTable_update(dt, "course_id", "C12", "size", "100");

            string[] clmn = new string[] { "course_id", "course_name", "type", "facl_id", "size", "marks", "quantity", "begin_date", "contract" };
            string[] clmn_value = new [] { "C13", "Algebra", "Mathematics", "SC0", "2000", "7,00", "40", "2014-05-05", "1" };
            //Console.WriteLine(Convert.ToDecimal(clmn_value[5]));

            bool result = commonDb.MyTable_insert_bldr(dt, "course_id", clmn, clmn_value);


            Console.WriteLine(result);

            //DB_work mywrk = new DB_work(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\tect_datasets_db.mdf;Integrated Security=True;Connect Timeout=30");
            //mywrk.DB_conn();
            //Console.WriteLine("Reading courses table");
            //mywrk.Courses_Read("courses");
            //Console.WriteLine();

            //Console.WriteLine("Update courses table");
            //mywrk.Courses_Update("courses", "course_id", "C13", "begin_date", "2014-01-06");

            //Console.WriteLine("Reading courses table");
            //mywrk.Courses_Read("courses");
            //Console.WriteLine();

            //Console.WriteLine("Update courses table by DataSet");
            //mywrk.Courses_Update_ds("courses", "course_id", "C13", "begin_date", "2013-01-01");

            //Console.WriteLine("Reading courses table");
            //mywrk.Courses_Read("courses");
            //Console.WriteLine();

            //Console.WriteLine("Update courses table by Builder");
            //mywrk.Courses_Update_bldr("courses", "course_id", "C13", "begin_date", "2012-01-01");

            //Console.WriteLine("Reading courses table");
            //mywrk.Courses_Read("courses");
            //Console.WriteLine();

            //Console.WriteLine("Insert  to courses table by Builder");
            //string[] clmns = new string[] { "course_name", "contract", "facl_id" };
            //string[] clmn_values = new string[] { "biology", "0", "" };
            //mywrk.Courses_Insert_bldr("courses", "course_id", clmns, clmn_values);

            //Console.WriteLine("Reading courses table");
            //mywrk.Courses_Read("courses");
            //Console.WriteLine();

            //Console.WriteLine("Delete from courses table");

            //Console.WriteLine("Write  key to delete: \r\n");
            //string del_key = Console.ReadLine();
            //mywrk.Courses_Delete("courses", "course_id", del_key);

            //Console.WriteLine("Reading courses table");
            //mywrk.Courses_Read("courses");



            Console.Read();
        }
    }

}
