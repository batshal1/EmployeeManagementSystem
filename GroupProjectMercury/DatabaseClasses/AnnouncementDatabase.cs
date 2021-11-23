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
    public static class AnnouncementDatabase
    {
        // 'announcements'
        public static List<Announcement> GetAnnouncements()
        {
            List<Announcement> announcements = new List<Announcement>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM announcement";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Announcement announcement;

                    DateTime date = Convert.ToDateTime(dataReader[1]);
                    string text = Convert.ToString(dataReader[3]);
                    string title = Convert.ToString(dataReader[4]);
                    DateTime enddate = Convert.ToDateTime(dataReader[2]);

                    announcement = new Announcement(date, text, title, enddate);
                    announcements.Add(announcement);
                }
                connection.Close();
                return announcements;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Announcement>();
            }
        }

        public static void PostAnnouncement(Announcement announcement)
        {
            try
            {
                DateTime date = announcement.date;
                string text = announcement.text;
                string title = announcement.title;
                DateTime enddate = announcement.enddate;

                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SET FOREIGN_KEY_CHECKS=0;" +
                    "INSERT INTO `announcement`(`publishdate`, `expiredate`, `announcement`, `title`) VALUES (@date,@enddate,@text,@title);" +
                    "SET FOREIGN_KEY_CHECKS=1;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@enddate", enddate);
                cmd.Parameters.AddWithValue("@text", text);
                cmd.Parameters.AddWithValue("@title", title);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void EditAnnouncement(DateTime date, string text, string title, DateTime enddate, string oldText)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE announcement SET publishdate = @date, expiredate = @enddate, title = @title, announcement = @text WHERE announcement = @oldText";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@enddate", enddate);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@text", text);
                cmd.Parameters.AddWithValue("@oldText", oldText);
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
