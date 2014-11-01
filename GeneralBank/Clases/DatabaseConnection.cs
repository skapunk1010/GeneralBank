using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GeneralBank.Clases
{
    class DatabaseConnection
    {
        private const String CONNECTION_STRING = "server=localhost; database=generalbank; Uid=root; pwd=; ";
        private static MySqlConnection currentConnection = null;
        private static String sql_string = "";
        private static String error_message = "";
        private static List<string> arrayResult = new List<string>();

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
                currentConnection = new MySqlConnection(CONNECTION_STRING);
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

        public static int ExecuteStatement() //INSERT, UPDATE, and DELETE statements
        {
            Connect();
            long lastId;
            try
            {
                MySqlCommand command = currentConnection.CreateCommand();
                command.CommandText = sql_string;
                command.ExecuteNonQuery();
                lastId = command.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                error_message = ex.ToString();
                lastId = 0;
            }
            catch (InvalidOperationException ex)
            {
                error_message = ex.ToString();
                lastId = 0;
            }
            finally
            {
                Close();
            }
            return Convert.ToInt32(lastId);
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
            catch (InvalidOperationException ex)
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

        public static float ExecuteFloatReader() //Retrieve one float data 
        {
            Connect();
            MySqlCommand command = null;
            MySqlDataReader rdr = null;
            float result = 0;

            try
            {
                string stm = sql_string;
                command = new MySqlCommand(stm, currentConnection);
                rdr = command.ExecuteReader();

                ArrayResult.Clear();
                result = (float) rdr.GetDecimal(0);
            }
            catch (MySqlException ex)
            {
                error_message = ex.ToString();
            }
            catch (InvalidOperationException ex)
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
            return result;
        }
    }
}
