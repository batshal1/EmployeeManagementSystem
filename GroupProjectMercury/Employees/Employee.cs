using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public abstract class Employee
    {
        //public static int idSeeder = 1;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string Bsn { get; set; }

        private List<DateTime> preferences;

        public int DeptId { get; set; }

        public Employee( string firstname, string lastname, DateTime birthdate, string gender, string street, string zipcode, string city, string phonenumber, string email, DateTime startdate, string position, double salary, string bsn)
        {
            //this.Id = idSeeder++;
           
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Gender = gender;
            this.Email = email;
            this.PhoneNumber = phonenumber;
            this.DateOfBirth = birthdate;
            this.Street = street;
            this.ZipCode = zipcode;
            this.City = city;
            this.StartDate = startdate;
            this.Position = position;
            this.Salary = salary;
            this.Bsn = bsn;
        }

        public override string ToString()
        {
            return $"ID: {Id}, {FirstName} {LastName}";
        }


        public void SetPreferences(List<DateTime> newPreferences)
        {
            preferences = newPreferences;
        }

        public void AddPreference(DateTime date)
        {
            preferences.Add(date);
        }
    }
}
