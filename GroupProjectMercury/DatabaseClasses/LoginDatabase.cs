using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace GroupProjectMercury
{
    public static class LoginDatabase
    {
        // table 'user'
        // for blocking user in database table 'user'
        public static bool GetIsBlocked(string username)
        {            
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT isblocked FROM user WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                bool result = false;
                while (dataReader.Read() == true)
                {
                    result = Convert.ToBoolean(dataReader[0]);
                }
                connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static bool GetIsBlocked(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT id, isblocked FROM user WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                dataReader.Read();
                bool result = Convert.ToBoolean(dataReader[1]);

                connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static void SetIsBlocked(string username, bool newBlocked)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE user SET isblocked = @newblocked WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@newblocked", newBlocked);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void SetIsBlocked(int id, bool newblocked)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE user SET isblocked = @newblocked WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@newblocked", newblocked);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool GetUsernameExists(string username)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT username FROM user WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                bool result = false;
                if (dataReader.Read() == true)
                {
                    result = true;
                }
                connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return true;
            }
        }

        public static bool UserLookup(string username, string password)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT COUNT(*) FROM `user` WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();
                Object result = cmd.ExecuteScalar();
                int count = -1;
                if (result != null)
                {
                    count = Convert.ToInt32(result);
                    if (count == 1)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public static string GetPasswordPerId(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT password FROM user WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                string password = "";
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    password = dataReader[0].ToString(); // returns password
                }
                connection.Close();
                return password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static void UpdateEmployeePassword(string password, int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE `user` SET `password` = @password WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
