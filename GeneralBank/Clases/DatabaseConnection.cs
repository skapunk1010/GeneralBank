using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GeneralBank.Clases
{
    class DatabaseConnection
    {
        private static MySqlConnection currentConnection;
        private static String sql_string;
        private static String error_message;
        private static List<string> arrayResult;

        public DatabaseConnection()
        {
            currentConnection = null;
            sql_string = "";
            arrayResult = new List<string>();
        }

        public static String Sql_string
        {
            set { sql_string = value; }
        }

        public static String Error_message
        {
            get { return error_message; }
        }

        public static List<string> ArrayResult
        {
            get { return arrayResult; }
        }

        public static bool Connect()
        {
            bool result;
            try
            {
                currentConnection = new MySqlConnection("server=127.0.0.1; database=Nombre; Uid=root; pwd=;");
                currentConnection.Open();
                result = true;
            }
            catch (MySqlException ex) { result = false; error_message = ex.ToString(); }
            return result;
        }

        public static void Close()
        {
            try
            {
                if (currentConnection != null)
                {
                    currentConnection.Close();
                    currentConnection = null;
                }
            }
            catch { }
        }

        public static void ExecuteStatement() //INSERT, UPDATE, and DELETE statements
        {
            try
            {
                MySqlCommand command = currentConnection.CreateCommand();
                command.CommandText = sql_string;
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                error_message = ex.ToString();
            }
            finally
            {
                Close();
            }
        }

        public static void ExecuteReader() //Retrieve data from tables 
        {
            MySqlCommand command = null;
            MySqlDataReader rdr = null;

            try
            {
                string stm = sql_string;
                command = new MySqlCommand(stm, currentConnection);
                rdr = command.ExecuteReader();

                ArrayResult.Clear();
                while (rdr.Read())
                {
                    ArrayResult.Add(rdr.GetString(0));
                }
            }
            catch (MySqlException ex)
            {
                error_message = ex.ToString();
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                Close();
            }
        }
    }
}
