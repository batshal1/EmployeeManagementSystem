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
    public static class DepartmentDatabase
    {
        //'departments'

        public static bool AddDepartmentToDB(Department d)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SET FOREIGN_KEY_CHECKS=0;" +
                    "INSERT INTO `departments`(`name`) VALUES (@name);" +
                    "SET FOREIGN_KEY_CHECKS=1;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", d.Name);
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


        public static List<Department> GetAllDepartmentsFromDB()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM departments";
                List<Department> allDepartments = new List<Department>();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string name = dataReader[1].ToString();                    

                    allDepartments.Add(new Department(id, name));
                }
                dataReader.Close();
                connection.Close();
                return allDepartments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Department>();
            }
        }


        public static List<Employee> GetEmployeesPerDepartment(int deptid)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn FROM `employees` WHERE deptid = @deptid";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@deptid", deptid);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Employee> employees = new List<Employee>();
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
                        employee = new ShopWorker(firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "depotworker")
                    {
                        employee = new DepotWorker(firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else if (position == "administrator")
                    {
                        employee = new Administrator(firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }
                    else
                    {
                        employee = new Manager(firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    }

                    employees.Add(employee);
                }
                connection.Close();

                return employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }


        public static void AssignEmplToDepartToDB(int deptid, int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE employees SET deptid = @deptid WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@deptid", deptid);
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

        public static Department GetDepartmentByID(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT name FROM `departments` WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                Department department = null;

                while (dataReader.Read())
                {
                    string name = dataReader[0].ToString();

                    department = new Department(id, name);
                }
                
                connection.Close();

                return department;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
