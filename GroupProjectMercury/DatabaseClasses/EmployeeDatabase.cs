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
    public static class EmployeeDatabase
    {        
        // table 'employees'
        // get all employees who are working there (without the archived employees)
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> e = new List<Employee>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM employees WHERE enddate IS NULL";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Employee employee;
                    int id = Convert.ToInt32(dataReader[0]);
                    string firstname = dataReader[1].ToString();
                    string lastname = dataReader[2].ToString();
                    DateTime birthdate = Convert.ToDateTime(dataReader[3]);
                    string gender = dataReader[4].ToString();
                    string street = dataReader[5].ToString();
                    string zipcode = dataReader[6].ToString();
                    string city = dataReader[7].ToString();
                    string phonenumber = dataReader[8].ToString();
                    string email = dataReader[9].ToString();
                    DateTime startdate = Convert.ToDateTime(dataReader[10]);
                    string position = dataReader[12].ToString();
                    double salary = Convert.ToDouble(dataReader[13]);
                    string bsn = dataReader[14].ToString();
                    int deptid = Convert.ToInt32(dataReader[15]);

                    if (position == "shopworker")
                    {
                        employee = new ShopWorker(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "depotworker")
                    {
                        employee = new DepotWorker(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "administrator")
                    {
                        employee = new Administrator(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else
                    {
                        employee = new Manager(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    employee.DeptId = deptid;
                    e.Add(employee);
                }
                connection.Close();
                return e;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Employee>();
            }
        }

        public static List<int> GetAllIdsShopAndDepot()
        {
            List<int> e = new List<int>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT id, position FROM employees WHERE enddate IS NULL";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string position = dataReader[1].ToString();

                    if (position == "shopworker")
                    {                        
                        e.Add(id);
                    }
                    else if (position == "depotworker")
                    {
                        e.Add(id);
                    }
                }
                connection.Close();
                return e;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<int>();
            }
        }

        public static List<Employee> GetArchivedEmployees()
        {
            List<Employee> e = new List<Employee>();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM employees WHERE enddate IS NOT NULL";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Employee employee;
                    int id = Convert.ToInt32(dataReader[0]);
                    string firstname = dataReader[1].ToString();
                    string lastname = dataReader[2].ToString();
                    DateTime birthdate = Convert.ToDateTime(dataReader[3]);
                    string gender = dataReader[4].ToString();
                    string street = dataReader[5].ToString();
                    string zipcode = dataReader[6].ToString();
                    string city = dataReader[7].ToString();
                    string phonenumber = dataReader[8].ToString();
                    string email = dataReader[9].ToString();
                    DateTime startdate = Convert.ToDateTime(dataReader[10]);
                    string position = dataReader[12].ToString();
                    double salary = Convert.ToDouble(dataReader[13]);
                    string bsn = dataReader[14].ToString();

                    if (position == "shopworker")
                    {
                        employee = new ShopWorker(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "depotworker")
                    {
                        employee = new DepotWorker(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "administrator")
                    {
                        employee = new Administrator(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else
                    {
                        employee = new Manager(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }

                    e.Add(employee);
                }
                connection.Close();
                return e;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Employee>();
            }
        }

        public static double GetAverageSalary()
        {
            try
            {
                // every employee in the database should have a salary
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT id, salary FROM employee_detail WHERE salary IS NOT NULL";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                double totalSalary = 0;
                int countEmployees = 0;
                while (dataReader.Read())
                {
                    totalSalary += Convert.ToDouble(dataReader[1]);
                    countEmployees++;
                }

                double averageSalary = totalSalary / countEmployees;
                connection.Close();
                return Math.Round(averageSalary, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public static int GetIdOfEmployee(string username, string password)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT id FROM `user` WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public static Employee GetEmployeeByID(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn FROM `employees` WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                Employee employee = null;

                while (dataReader.Read())
                {
                    string firstname = dataReader[0].ToString();
                    string lastname = dataReader[1].ToString();
                    DateTime birthdate = Convert.ToDateTime(dataReader[2]);
                    string gender = dataReader[3].ToString();
                    string street = dataReader[4].ToString();
                    string zipcode = dataReader[5].ToString();
                    string city = dataReader[6].ToString();
                    string phonenumber = dataReader[7].ToString();
                    string email = dataReader[8].ToString();
                    DateTime startdate = Convert.ToDateTime(dataReader[9]);
                    string position = dataReader[10].ToString();
                    double salary = Convert.ToDouble(dataReader[11]);
                    string bsn = dataReader[12].ToString();

                    if (position == "shopworker")
                    {
                        employee = new ShopWorker(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "depotworker")
                    {
                        employee = new DepotWorker(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "administrator")
                    {
                        employee = new Administrator(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else
                    {
                        employee = new Manager(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                }
                connection.Close();

                return employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static List<int> GetAllIds()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT id FROM `employees`";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<int> tempIDs = new List<int>();

                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    tempIDs.Add(id);
                }
                connection.Close();

                return tempIDs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static string GetPositionFromID(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string nameSql = "SELECT position FROM employees WHERE id = @id";
                MySqlCommand PositionCmd = new MySqlCommand(nameSql, connection);
                PositionCmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                string position = Convert.ToString(PositionCmd.ExecuteScalar());
                connection.Close();
                return position;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "";
            }
        }

        public static void UpdateEmployeeSalary(int id, double salary)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE `employees` SET `salary` = @salary WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@salary", salary);
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

        public static void UpdateEmployeePosition(string position, int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE employees SET position = @position WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@position", position);
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

        public static void UpdateProfile(string street, string zipcode, string city, string phone, int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE `employees` SET `street` = @street, `zipcode` = @zipcode, `city` = @city, `phonenumber` = @phone WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@street", street);
                cmd.Parameters.AddWithValue("@zipcode", zipcode);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@phone", phone);
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

        public static bool AddNewEmployee(string username, string password, string firstname, string lastname, DateTime birthdate, string gender, string street, string zipcode, string city, string phonenumber, string email, DateTime startdate, string position, double salary, string bsn)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SET FOREIGN_KEY_CHECKS=0;" +
                    "INSERT INTO `user`(`username`, `password`) VALUES (@username,@password);" +
                    "INSERT INTO `employees`(`firstname`, `lastname`, `birthdate`, `gender`,`street`, `zipcode`, `city`, `phonenumber`, `email`, `startdate`, `position`, `salary`, `bsn`, `deptid`) VALUES (@firstname,@lastname,@birthdate,@gender,@street, @zipcode, @city, @phonenumber,@email,@startdate,@position,@salary, @bsn, 0);" +
                    "SET FOREIGN_KEY_CHECKS=1;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@street", street);
                cmd.Parameters.AddWithValue("@zipcode", zipcode);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@startdate", startdate);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@bsn", bsn);
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

        public static List<String> GetEmployeesExceptCurrentOne(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                List<String> employees = new List<String>();
                string employeessql = "SELECT id, name, surname, position FROM personals ";
                MySqlCommand cmd = new MySqlCommand(employeessql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (id != dataReader.GetInt32(0))
                    {
                        string name = "ID: " + dataReader[0] + " - Name: " + dataReader[1] + " " + dataReader[2] + " - Position: " + dataReader[3];
                        employees.Add(name);
                    }
                }
                dataReader.Close();
                connection.Close();
                return employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<string>();
            }
        }

        public static void Archive(int id, DateTime enddate)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE employees SET enddate = @enddate WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@enddate", enddate);
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

        public static List<Employee> SearchEmployees(string text)
        {
            try
            {
                string search = text;
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM employees WHERE CONCAT(id, firstname, lastname, gender, street, city, email, startdate, position) LIKE '%" + search + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Employee> employees = new List<Employee>();

                while (dataReader.Read())
                {
                    Employee employee;
                    int id = Convert.ToInt32(dataReader[0]);
                    string firstname = dataReader[1].ToString();
                    string lastname = dataReader[2].ToString();
                    DateTime birthdate = Convert.ToDateTime(dataReader[3]);
                    string gender = dataReader[4].ToString();
                    string street = dataReader[5].ToString();
                    string zipcode = dataReader[6].ToString();
                    string city = dataReader[7].ToString();
                    string phonenumber = dataReader[8].ToString();
                    string email = dataReader[9].ToString();
                    DateTime startdate = Convert.ToDateTime(dataReader[10]);
                    string position = dataReader[12].ToString();
                    double salary = Convert.ToDouble(dataReader[13]);
                    string bsn = dataReader[14].ToString();

                    if (position == "shopworker")
                    {
                        employee = new ShopWorker(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "depotworker")
                    {
                        employee = new DepotWorker(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "administrator")
                    {
                        employee = new Administrator(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else
                    {
                        employee = new Manager(id, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }

                    employees.Add(employee);
                }
                connection.Close();
                return employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Employee>();
            }
        }
    }
}
