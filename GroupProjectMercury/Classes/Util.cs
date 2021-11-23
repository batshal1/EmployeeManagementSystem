using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public static class Util
    {
        // employees
        public static int VIEW_ALL_EMPLOYEES = 0;
        public static int VIEW_EMPLOYEE = 1;
        public static int ADD_EMPLOYEE = 2;
        public static int REMOVE_EMPLOYEE = 3;
        public static int SEARCH_EMPLOYEE = 4;
        public static int CHANGE_POSITION = 5;
        public static int CHANGE_SALARY = 6;
        public static int ARCHIVE = 7;

        // products
        public static int VIEW_DATASTOCK = 8;
        public static int VIEW_RESTOCKREQUEST = 9;
        public static int ADD_PRODUCT = 10;
        public static int REMOVE_PRODUCT = 11;
        public static int RESTOCK_PRODUCT = 12;
        public static int SEARCH_PRODUCTS = 13;
        public static int GET_PRODUCTS = 14;

        // shifts
        public static int ASSIGN_SHIFT = 15;
        public static int VIEW_SHIFTS = 16;

        // statistics
        public static int VIEW_STATISTICS = 17;

        // announcements
        public static int POST_ANNOUNCEMENT = 18;

        // offdays
        public static int ADD_OFFDAY = 19;

        //departments
        public static int VIEW_DEPARTMENTS = 20;
        public static int MANAGE_DEPARTMENTS = 21;

        // and so on...
    }
}
