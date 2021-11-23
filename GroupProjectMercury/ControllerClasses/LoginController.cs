using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class LoginController
    {
        private int currentId;
        private Employee currentEmp;
        private Permissions permissions;

        public LoginController(int id)
        {
            currentId = id;
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentId);
            permissions = new Permissions();
        }

        // user
        public string CreateTemporaryPassword(int length)
        {
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789&é";
            Random random = new Random();
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }

        public bool ChangeOwnPassword(string oldPassword, string newPassword)
        {
            if (oldPassword == LoginDatabase.GetPasswordPerId(currentId)) // everyone is allowed to change their own password
            {
                LoginDatabase.UpdateEmployeePassword(newPassword, currentId);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
