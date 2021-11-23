using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace GroupProjectMercury.Forms
{
    public static class ScheduleDatabase
    {
        // `shifts`
        public static void SetShift(Shift shift)
        {
            try
            {
                int empid = shift.EmpId;
                DateTime date = shift.Date;
                string timeofday = shift.TimeOfDay;
                DateTime starttime = shift.StartTime;
                DateTime endtime = shift.EndTime;

                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SET FOREIGN_KEY_CHECKS=0;" +
                    "INSERT INTO `shifts`(`empid`, `date`, `timeofday`, `starttime`, `endtime`) VALUES (@empid,@date,@timeofday,@starttime,@endtime);" +
                    "SET FOREIGN_KEY_CHECKS=1;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@empid", empid);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@timeofday", timeofday);
                cmd.Parameters.AddWithValue("@starttime", starttime);
                cmd.Parameters.AddWithValue("@endtime", endtime);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void RemoveShift(Shift shift)
        {
            try
            {
                int empid = shift.EmpId;
                DateTime date = shift.Date;
                string timeofday = shift.TimeOfDay;
                DateTime starttime = shift.StartTime;
                DateTime endtime = shift.EndTime;

                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SET FOREIGN_KEY_CHECKS=0;" +
                    "DELETE FROM shifts WHERE empId = @empId AND date = @date AND timeofday = @timeofday;" +
                    "SET FOREIGN_KEY_CHECKS=1;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@empId", empid);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@timeofday", timeofday);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void CheckShift(Shift shift)
        {
            try
            {
                int empid = shift.EmpId;
                DateTime date = shift.Date;
                string timeofday = shift.TimeOfDay;
                DateTime starttime = shift.StartTime;
                DateTime endtime = shift.EndTime;

                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM shifts";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@empid", empid);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@timeofday", timeofday);
                cmd.Parameters.AddWithValue("@starttime", starttime);
                cmd.Parameters.AddWithValue("@endtime", endtime);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static List<Shift> GetAllShifts()
        {
            List<Shift> shifts = new List<Shift>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM shifts";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Shift shift;

                    int empid = Convert.ToInt32(dataReader[1]);
                    DateTime date = Convert.ToDateTime(dataReader[2]);
                    string timeofday = dataReader[3].ToString();
                    TimeSpan starttime = Convert.ToDateTime(dataReader[4]).TimeOfDay;
                    TimeSpan endtime = Convert.ToDateTime(dataReader[5]).TimeOfDay;

                    shift = new Shift(empid, date, starttime, endtime, timeofday);

                    shifts.Add(shift);
                }
                connection.Close();
                return shifts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Shift>();
            }
        }

        public static List<Shift> GetShiftsPerId(int id)
        {
            List<Shift> shifts = new List<Shift>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM shifts WHERE empId = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int empid = Convert.ToInt32(dataReader[1]);
                    DateTime dateshift = Convert.ToDateTime(dataReader[2]);
                    string timeofday = dataReader[3].ToString();
                    TimeSpan starttime = Convert.ToDateTime(dataReader[4]).TimeOfDay;
                    TimeSpan endtime = Convert.ToDateTime(dataReader[5]).TimeOfDay;

                    shifts.Add(new Shift(empid, dateshift, starttime, endtime, timeofday));
                }
                connection.Close();
                return shifts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return shifts;
            }
        }

        public static List<Shift> GetShiftsPerIdAndDate(List<Shift> ss, DateTime dateTime)
        {
            List<Shift> tempshifts = new List<Shift>();
            for (int i = 0; i < ss.Count; i++)
            {
                if (ss[i].Date == dateTime)
                {
                    tempshifts.Add(ss[i]);
                }
            }

            return tempshifts;
        }

        public static Shift CheckDateOfShift(int id, DateTime date)
        {
            Shift shift = null;
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM shifts WHERE empId = @id AND date = @date";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("date", date);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int empid = Convert.ToInt32(dataReader[1]);
                    DateTime dateshift = Convert.ToDateTime(dataReader[2]);
                    string timeofday = dataReader[3].ToString();
                    TimeSpan starttime = Convert.ToDateTime(dataReader[4]).TimeOfDay;
                    TimeSpan endtime = Convert.ToDateTime(dataReader[5]).TimeOfDay;

                    shift = new Shift(empid, dateshift, starttime, endtime, timeofday);
                }
                connection.Close();
                return shift;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return shift;
            }
        }

        public static List<Employee> GetEmployeesOfShiftsPerDateAndTime(DateTime date, string timeofday)
        {
            List<Employee> tempEmp = new List<Employee>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT empId FROM shifts WHERE date = @date AND timeofday = @timeofday";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@timeofday", timeofday);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int empid = Convert.ToInt32(dataReader[0]);
                    Employee e = EmployeeDatabase.GetEmployeeByID(empid);
                    tempEmp.Add(e);
                }
                connection.Close();
                return tempEmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Employee>();
            }
        }

        public static List<Shift> GetShiftsPerMonth(DateTime startdate, DateTime enddate)
        {
            List<Shift> s = new List<Shift>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = $"SELECT * FROM shifts WHERE date BETWEEN #{startdate}# AND #{enddate}#";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Shift shift;

                    int empid = Convert.ToInt32(dataReader[1]);
                    DateTime date = Convert.ToDateTime(dataReader[2]);
                    string timeofday = dataReader[3].ToString();
                    TimeSpan starttime = Convert.ToDateTime(dataReader[4]).TimeOfDay;
                    TimeSpan endtime = Convert.ToDateTime(dataReader[5]).TimeOfDay;

                    shift = new Shift(empid, date, starttime, endtime, timeofday);
                    s.Add(shift);
                }
                connection.Close();
                return s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Shift>();
            }
        }


        // 'offdays'
        public static List<DateTime> GetOffDays()
        {
            List<DateTime> offdays = new List<DateTime>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM offdays";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    DateTime date = Convert.ToDateTime(dataReader[0]);
                    offdays.Add(date);
                }
                connection.Close();
                return offdays;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<DateTime>();
            }
        }

        public static void AddOffDay(DateTime date)
        {
            try
            {
                DateTime offdate = date;

                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SET FOREIGN_KEY_CHECKS=0;" +
                    "INSERT INTO `offdays`(`date`) VALUES (@date);" +
                    "SET FOREIGN_KEY_CHECKS=1;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@date", date);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        // preferences
        public static List<DateTime> GetPreferences()
        {
            List<DateTime> dates = new List<DateTime>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM preferences";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    DateTime date = Convert.ToDateTime(dataReader[2]);

                    dates.Add(date);
                }
                connection.Close();
                return dates;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dates;
            }
        }

        public static List<DateTime> GetPreferencesByEmployee(int id)
        {
            List<DateTime> dates = new List<DateTime>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM preferences WHERE empId = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    DateTime date = Convert.ToDateTime(dataReader[2]);
                    dates.Add(date);
                }
                connection.Close();
                return dates;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dates;
            }
        }

        public static bool SendPreferences(int i, DateTime d)
        {
            try
            {
                DateTime date = d;
                int id = i;

                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SET FOREIGN_KEY_CHECKS=0;" +
                        "INSERT INTO `preferences`(`empid`, `date`) VALUES (@id,@date);" +
                        "SET FOREIGN_KEY_CHECKS=1;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }

        public static bool IsAvailable(int id)
        {
            List<DateTime> dates = new List<DateTime>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM preferences WHERE empId = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    DateTime date = Convert.ToDateTime(dataReader[2]);
                    dates.Add(date);
                }
                connection.Close();

                if (dates.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static bool CheckPreferenceDay(int id, DateTime day)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM preferences WHERE empId = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    DateTime date = Convert.ToDateTime(dataReader[2]);
                    if (day == date)
                    {
                        return true;
                    }
                }
                connection.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }        

        public static int GetCountOfShiftsPerDateAndTime(DateTime dt, string timeofday)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT COUNT(empId) FROM shifts WHERE date = @date AND timeofday = @timeofday GROUP BY date, timeofday";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@date", dt);
                cmd.Parameters.AddWithValue("@timeofday", timeofday);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    count = Convert.ToInt32(dataReader[0]);
                }
                connection.Close();
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }
    }
}
