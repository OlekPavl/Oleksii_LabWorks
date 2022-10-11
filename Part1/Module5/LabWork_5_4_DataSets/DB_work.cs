using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LabWork_5_4_DataSets
{
    class DB_work
    {
        // declare    Common_db MyDBtest   
        public Common_db MyDBtest;
        // implement DB_work(string conn) constructor to initiate MyDBtest
        public DB_work(string conn)
        {
            MyDBtest = new Common_db(conn);
        }

        // implement  void DB_conn() to check the MyDBtest 
        public void DB_conn()
        {
            // try check connection using MyConnect() and MyDisConnect()
            if (MyDBtest.MyConnectOpen())
            {
                Console.WriteLine("Connection opened");
            }
            else
            {
                Console.WriteLine("Connection closed");
            }
            
        }

        // implement void Courses_Update_ds(string table_name, string key, string key_value, string clmn, string clmn_value)
        // to update table_name using MyDBtest.MyTable_update_ds method with parameters in try-catch block
        public void Courses_Update_ds(string table_name, string key, string key_value, string clmn, string clmn_value)
        {
            try
            {
                MyDBtest.MyTable_update_ds(table_name, key, key_value, clmn, clmn_value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // implement void Courses_Insert_bldr(string table_name, string key,  string [] clmn, string[] clmn_value)
        // to insert into table_name using MyDBtest.MyTable_insert_bldr method with parameters in try-catch block
        public void Courses_Insert_bldr(string table_name, string key, string[] clmn, string[] clmn_value)
        {
            try
            {
                MyDBtest.MyTable_insert_bldr(table_name, key, clmn, clmn_value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        // implement void Courses_Update_bldr(string table_name, string key, string key_value, string clmn, string clmn_value)
        // to update table_name using MyDBtest.MyTable_update_bldr method with parameters in try-catch block
        public void Courses_Update_bldr(string table_name, string key, string key_value, string clmn, string clmn_value)
        {
            try
            {
                MyDBtest.MyTable_update_bldr(table_name, key, key_value, clmn, clmn_value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // implement void Courses_Update(string table_name, string key, string key_value, string clmn, string clmn_value)
        // to update table_name using MyDBtest.MyTable_update method with parameters in try-catch block
        public void Courses_Update(string table_name, string key, string key_value, string clmn, string clmn_value)
        {
            try
            {
                //create new DataTable object and define its TableName property
                //call MyDBtest.MyTable_update with parameters
                MyDBtest.MyTable_update(new DataTable(table_name), key, key_value, clmn, clmn_value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // implement void Courses_Read(string table_name) method
        // to read table_name using MyDBtest.MyTable_read method with parameters in try-catch block
        public void Courses_Read(string table_name)
        {
            try
            {
                //create new DataTable object and define its TableName property

                //call MyDBtest.MyTable_read with parameter
                //foreach DataRow item  write its value to the console
                MyDBtest.MyTable_read(new DataTable(table_name));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // implement Courses_Delete(string table_name, string key, string key_value) method
        // to delete row from the table_name using MyDBtest.MyTable_delete method with parameters in try-catch block
        public void Courses_Delete(string table_name, string key, string key_value)
        {
            try
            {
                //create new DataTable object and define its TableName property
                //call MyDBtest.MyTable_delete with parameters
                MyDBtest.MyTable_delete(new DataTable(table_name), key, key_value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
