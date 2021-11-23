using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectMercury.Forms
{
    public partial class Statistics : Form
    {
        private Controller controller;
        private int currentID;

        public Statistics(int id)
        {
            InitializeComponent();
            currentID = id;
            controller = new Controller(currentID);
            FillInAvergAndTotal();
            FillCharts();
        }

        public void FillInAvergAndTotal()
        {
            lbTotalNr.Text = Convert.ToString(controller.GetTotalNrOfEmployees());
            lbAverageSal.Text = Convert.ToString(controller.GetAverageSalary()) + " € per hour";
        }

        public void FillCharts()
        {
            chart1.Titles.Add("Number of employees per type");
            chart1.Series["Number of people"].IsValueShownAsLabel = true;
            this.chart1.Series["Number of people"].Points.AddXY("Administrators", controller.GetNrOfType("GroupProjectMercury.Forms.Administrator")); 
            this.chart1.Series["Number of people"].Points.AddXY("Managers", controller.GetNrOfType("GroupProjectMercury.Forms.Manager"));
            this.chart1.Series["Number of people"].Points.AddXY("Shopworkers", controller.GetNrOfType("GroupProjectMercury.Forms.ShopWorker"));
            this.chart1.Series["Number of people"].Points.AddXY("Depotworkers", controller.GetNrOfType("GroupProjectMercury.Forms.DepotWorker"));

            chart3.Titles.Add("Gender division");
            chart3.Series["gender"].IsValueShownAsLabel = true;
            this.chart3.Series["gender"].Points.AddXY("Male", controller.GetNrPerGender("Male"));
            this.chart3.Series["gender"].Points.AddXY("Female", controller.GetNrPerGender("Female"));
            this.chart3.Series["gender"].Points.AddXY("Other", controller.GetNrPerGender("Other"));

            chart2.Titles.Add("Age categories");
            chart2.Series["Nr of people"].IsValueShownAsLabel = true;
            
            this.chart2.Series["Nr of people"].Points.AddXY("<20", controller.GetNrPerAge(2000, 2003));
            this.chart2.Series["Nr of people"].Points.AddXY("20-30", controller.GetNrPerAge(1990, 2000));
            this.chart2.Series["Nr of people"].Points.AddXY("30-40", controller.GetNrPerAge(1980, 1990));
            this.chart2.Series["Nr of people"].Points.AddXY("40-50", controller.GetNrPerAge(1970, 1980));
            this.chart2.Series["Nr of people"].Points.AddXY(">50", controller.GetNrPerAge(1940, 1970));
        }

        //---------------- for nav bar
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmployee = new ViewEmployee(currentID);
            viewEmployee.Show();
            this.Close();
        }
    }
}
