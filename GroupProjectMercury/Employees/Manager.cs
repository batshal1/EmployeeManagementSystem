using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class Manager : Employee
    {
        public Manager ( string firstname, string lastname, DateTime birthdate, string gender, string street, string zipcode, string city, string phonenumber, string email, DateTime startdate, string position, double salary, string bsn) : base( firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn)
        {

        }

        public Manager(int id, string firstname, string lastname, DateTime birthdate, string gender, string street, string zipcode, string city, string phonenumber, string email, DateTime startdate, string position, double salary, string bsn) : base(firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn)
        {
            base.Id = id;
        }

        public override string ToString()
        {
            return $"Manager = {base.ToString()}";
        }
    }
}
