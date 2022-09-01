using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LabWork_5_4_DataSets
{
    internal class Common_db
    {
        // define string MyConnectionString
        // implement Common_db constructor with string parameter for connection string
        string MyConnection { get; set; }
        public Common_db(string myConnection)
        {
            MyConnection = myConnection;
        }
        public static SqlDataAdapter CreateCustomerAdapter(DataTable usr_table, SqlConnection connection)
        {
            //SqlConnection connection = new SqlConnection(dbcon);
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the SelectCommand.
            SqlCommand command = new SqlCommand("SELECT * FROM " + usr_table.TableName, connection);

            adapter.SelectCommand = command;
            
            // Create the InsertCommand.
            command = new SqlCommand(
                "INSERT INTO courses (course_id, course_name, type, facl_id, size, marks, quantity, begin_date, contract) " +
                "VALUES (@course_id, @course_name, @type, @facl_id, @size, @marks, @quantity, @begin_date, @contract)", connection);

            // Add the parameters for the InsertCommand.
            command.Parameters.Add("@course_id", SqlDbType.Char, 3, "course_id");
            command.Parameters.Add("@course_name", SqlDbType.VarChar, 40, "course_name");
            command.Parameters.Add("@type", SqlDbType.VarChar, 2, "type");
            command.Parameters.Add("@facl_id", SqlDbType.Char, 3, "facl_id");
            command.Parameters.Add("@size", SqlDbType.Int, 4, "size");
            command.Parameters.Add("@marks", SqlDbType.Decimal, 17, "marks");
            command.Parameters.Add("@quantity", SqlDbType.Int, 4, "quantity");
            command.Parameters.Add("@begin_date", SqlDbType.Date, 3, "begin_date");
            command.Parameters.Add("@contract", SqlDbType.SmallInt, 2, "contract");

            adapter.InsertCommand = command;

            // Create the UpdateCommand.
            command = new SqlCommand(
                "UPDATE " + usr_table.TableName + " SET course_id = @course_id, course_name = @course_name, type = @type, facl_id = , size = @size, marks = @marks, quantity = @quantity, begin_date = @begin_date, contract = @contract " +
                "WHERE course_id = @course_id", connection);

            // Add the parameters for the UpdateCommand.
            command.Parameters.Add("@course_id", SqlDbType.Char, 3, "course_id");
            command.Parameters.Add("@course_name", SqlDbType.VarChar, 40, "course_name");
            command.Parameters.Add("@type", SqlDbType.VarChar, 2, "type");
            command.Parameters.Add("@facl_id", SqlDbType.Char, 3, "facl_id");
            command.Parameters.Add("@size", SqlDbType.Int, 4, "size");
            command.Parameters.Add("@marks", SqlDbType.Decimal, 17, "marks");
            command.Parameters.Add("@quantity", SqlDbType.Int, 4, "quantity");
            command.Parameters.Add("@begin_date", SqlDbType.Date, 3, "begin_date");
            command.Parameters.Add("@contract", SqlDbType.SmallInt, 2, "contract");


            SqlParameter parameter = command.Parameters.Add(
                "@course_id", SqlDbType.Char, 3, "course_id");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.UpdateCommand = command;

            // Create the DeleteCommand.
            command = new SqlCommand(
                "DELETE FROM " + usr_table.TableName + " WHERE course_id = @course_id", connection);
            
            // Add the parameters for the DeleteCommand.
            parameter = command.Parameters.Add(
                "@course_id", SqlDbType.Char, 3, "course_id");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.DeleteCommand = command;


            return adapter;
        }

        // implement bool MyTable_delete(DataTable usr_table, string key, string key_value) method
        // with parameters fot DataTable , string key name, string key value to delete row
        public bool MyTable_delete(DataTable usr_table, string key, string key_value)
        {
            // define bool result and initiate it with false
            bool result = false;
            // in try-catch block implement using block for work new SglConnection with connection string MyConnectionString
            try
            {
                using (SqlConnection connection = new SqlConnection(MyConnection))
                {
                    connection.Open();
                    
                    // create SqlDataAdapter object associated with SqlCommand object
                    SqlDataAdapter adapter = CreateCustomerAdapter(usr_table, connection);
                    // populate usr_table by data from database
                    adapter.Fill(usr_table);
                    //foreach (DataRow row in usr_table.Rows)
                    //{
                    //    Console.WriteLine(row[0].ToString());

                    //}

                    // define usr_table primary key by new DataColumn[], initiate it by key value
                    usr_table.PrimaryKey = new DataColumn[] { usr_table.Columns[key] };

                    //define DataRow object as the usr_table row with key value which equals key_value
                    DataRow rowObject = usr_table.Rows.Find(key_value);
                    int index = usr_table.Rows.IndexOf(rowObject);

                  
                    // in try-catch block open connection, create adapter UpdateCommand  using connection CreateCommand method
                    try
                    {
                        usr_table.Rows[index].Delete();
                        adapter.Update(usr_table);

                        result = true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        result = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }

            return result;
        }
             
        // implement bool MyTable_update(DataTable usr_table, string key, string key_value, string clmn, string clmn_value) method
        // with parameters fot DataTable , string key name, string key value, string clmn, string clmn_value to update row
        public bool MyTable_update(DataTable usr_table, string key, string key_value, string clmn, string clmn_value)
        {
            bool result = false;

            // in try-catch block implement using block for work new SglConnection with connection string MyConnectionString
            try
            {
                // populate usr_table by data from database
                using (SqlConnection connection = new SqlConnection(MyConnection))
                {
                    connection.Open();
                    string sql = "SELECT * FROM " + usr_table.TableName;
                    // create SqlDataAdapter object associated with SqlCommand object
                    //SqlDataAdapter adapter = CreateCustomerAdapter(usr_table, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    // populate usr_table by data from database
                    adapter.Fill(usr_table);
                    //foreach (DataRow row in usr_table.Rows)
                    //{
                    //    Console.WriteLine(row[0].ToString());

                    //}

                    // define usr_table primary key by new DataColumn[], initiate it by key value
                    usr_table.PrimaryKey = new DataColumn[] { usr_table.Columns[key] };

                    //define DataRow object as the usr_table row with key value which equals key_value
                    DataRow rowObjectLine = usr_table.Rows.Find(key_value);
                    int rowIndex = usr_table.Rows.IndexOf(rowObjectLine);
                    int cellIndex = usr_table.Columns.IndexOf(clmn);

                    //foreach (DataRow row in usr_table.Rows)
                    //{
                    //    Console.WriteLine(row[3].ToString());

                    //}


                    // in try-catch block open connection, create adapter UpdateCommand  using connection CreateCommand method
                    try
                    {
                        DataRow dr = usr_table.Rows[rowIndex];
                        dr[cellIndex] = clmn_value;

                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                        adapter.Update(usr_table);

                        //adapter.Update(usr_table);

                        result = true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        result = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }

            return result;
        }

        // implement bool MyTable_insert_bldr(string usr_table, string key,  string[] clmn, string[] clmn_value) method
        // with parameters fot DataTable , string key name, string clmn, string clmn_value to insert row
        public bool MyTable_insert_bldr(DataTable usr_table, string key, string[] clmn, string[] clmn_value)
        {
            bool result = false;

            // in try-catch block implement using block for work new SglConnection with connection string MyConnectionString
            try
            {
                // populate usr_table by data from database
                using (SqlConnection connection = new SqlConnection(MyConnection))
                {
                    connection.Open();
                    string sql = "SELECT * FROM " + usr_table.TableName;
                    // create SqlDataAdapter object associated with SqlCommand object
                    //SqlDataAdapter adapter = CreateCustomerAdapter(usr_table, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    // populate usr_table by data from database
                    adapter.Fill(usr_table);
                    //foreach (DataRow row in usr_table.Rows)
                    //{
                    //    Console.WriteLine(row[0].ToString());

                    //}

                    // define usr_table primary key by new DataColumn[], initiate it by key value
                    usr_table.PrimaryKey = new DataColumn[] { usr_table.Columns[key] };

                    //define DataRow object as the usr_table row with key value which equals key_value
                    // добавим новую строку
                    DataRow newRow = usr_table.NewRow();
                    newRow[clmn[0]] = Next_key_gen(usr_table, key);
                    newRow[clmn[1]] = $"{clmn_value[1]}";
                    newRow[clmn[2]] = $"{clmn_value[2]}";
                    newRow[clmn[3]] = $"{clmn_value[3]}";
                    newRow[clmn[4]] = Convert.ToInt32(clmn_value[4]);
                    newRow[clmn[5]] = Convert.ToDecimal(clmn_value[5]);
                    newRow[clmn[6]] = Convert.ToInt32(clmn_value[6]);
                    newRow[clmn[7]] = Convert.ToDateTime(clmn_value[7]);
                    newRow[clmn[8]] = Convert.ToInt16(clmn_value[8]);

                    usr_table.Rows.Add(newRow);

                    foreach (DataRow row in usr_table.Rows)
                    {
                        Console.WriteLine(row[0].ToString());

                    }

                    //return true;

                    // in try-catch block open connection, create adapter UpdateCommand  using connection CreateCommand method
                    try
                    {

                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                        adapter.Update(usr_table);

                        //adapter.Update(usr_table);

                        result = true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        result = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }

            return result;
        }

        // implement string Next_key_gen(DataTable dt, string key ) method  to receive the next key value
        public string Next_key_gen(DataTable dt, string key)
        {
            string max = null;
            string nextKey = null;
            // in try-catch block implement using block for work new SglConnection with connection string MyConnectionString
            try
            {
                max = dt.AsEnumerable().Select(x => x[key].ToString()).Max();
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(max[1]);
                stringBuilder.Append(max[2]);
                //max = max.TrimStart('C');

                nextKey = "C" + (Convert.ToInt32(stringBuilder.ToString()) + 1).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Max key: {0} . Next_Key: {1} \n", max, nextKey);

            return nextKey;

        }


        // implement bool MyTable_update_bldr(string usr_table, string key, string key_value, string clmn, string clmn_value) method
        // with parameters fot table name , string key name,  string key_value,string clmn, string clmn_value to update the table
        public bool MyTable_update_bldr(string usr_table, string key, string key_value, string clmn, string clmn_value)
        {
            // define bool result and initiate it with false
            bool result = false;

            // in try-catch block implement using block for work new SglConnection with connection string MyConnectionString
            try
            {

                using (SqlConnection connection = new SqlConnection(MyConnection))
                {
                    connection.Open();

                    // create SqlCommand object for SglConnection object
                    SqlCommand command = new SqlCommand();

                    string sql = "SELECT * FROM " + usr_table;

                    // create SqlDataAdapter object associated with SqlCommand object
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);   
                    // Set up the CommandBuilder
                    SqlCommandBuilder commamdBuilder = new SqlCommandBuilder();

                    // create new DataSet
                    DataSet ds = new DataSet();
                    // fill it using usr_table
                    adapter.Fill(ds);
                    // define DataTable object  from DataSet with usr_table name
                    DataTable dt = ds.Tables[0];
                    dt.TableName = usr_table;
                    // accept changes for DataTable object
                    dt.AcceptChanges();

                    // define its primary key by new DataColumn[], initiate it by key value
                    dt.PrimaryKey = new DataColumn[] { dt.Columns[key] };

                    // create DataRow object and assign  DataTable object Rows.Find(key_value) result to it
                    DataRow rowObjectLine = dt.Rows.Find(key_value);
                    int rowIndex = dt.Rows.IndexOf(rowObjectLine);
                    int cellIndex = dt.Columns.IndexOf(clmn);


                    try
                    {
                        DataRow dr = dt.Rows[rowIndex];
                        // assign to its clmn column clmn_value
                        dr[cellIndex] = clmn_value;

                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                        
                        // call adapter Update method to update usr_table
                        adapter.Update(dt);



                        result = true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        result = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }

            return result;
        }
 


        // implement bool MyTable_update_ds(string usr_table, string key, string key_value, string clmn, string clmn_value) method
        // with parameters fot table name , string key name,  string key_value, string clmn, string clmn_value to update the table

        // define bool result and initiate it with false
        // in try-catch block implement using block for work new SglConnection with connection string MyConnectionString

        // create SqlCommand object for SglConnection object
        // define its CommandText like sql query to select all from "usr_table" from database

        // create SqlDataAdapter object associated with SqlCommand object

        // create new DataSet
        // fill it using usr_table

        // define DataTable object  from DataSet with usr_table name

        // define its primary key by new DataColumn[], initiate it by key value
        // accept changes for DataTable object

        // create DataRow object and assign  DataTable object Rows.Find(key_value) result to it

        // assign to its clmn column clmn_value

        // create string for sql query to update clmn column for clmn_value where key = key_value

        // in try-catch block open connection, create adapter UpdateCommand  using connection CreateCommand method

        // Open connection
        // define UpdateCommand for adapter 
        // define its CommandText for string to update row
        // call adapter update method to update usr_table


        // exception message output

        // assign true for result

        // return result

        // exception message output
        // return false




        //implement bool MyTable_read(DataTable usr_table) method to read from usr_table

        // define bool result and initiate it with false
        // in try-catch block implement using block for work new SglConnection with connection string MyConnectionString

        // create SqlCommand object for SglConnection object
        // define its CommandText like sql query to select all from "usr_table" from database

        // create SqlDataAdapter object associated with SqlCommand object
        // fill  usr_table

        // define DataTable object  from DataSet with usr_table name

        // assign true for result

        // return result

        // exception message output
        // return false




        // implement MyConnect() method to open and check the connection

        // define bool result and initiate it with false
        // in try-catch block implement using block for work new SglConnection with connection string MyConnectionString

        // Open connection
        // assign true for result

        // return result

        // exception message output
        // return false


        // implement MyConnect() method to close and check the connection

        // define bool result and initiate it with false
        // in try-catch block implement using block for work new SglConnection with connection string MyConnectionString

        // close connection
        // assign true for result

        // return result

        // exception message output
        // return false
    }
}
