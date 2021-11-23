using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GroupProjectMercury.Forms
{
    public partial class Depot : Form
    {
        private StockController stockController;
        private int currentID;
        private Employee currentEmp;

        public Depot(int id)
        {
            InitializeComponent();
            currentID = id;
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentID);
            stockController = new StockController(currentID);

            // fill DataGridView with
            dgvProducts.DataSource = stockController.GetProducts();

            // set navbar buttons visibility
            if (currentEmp.Position == "administrator")
            {
                btnEmployee.Visible = true;
                btnDepot.Visible = true;
                
                gbxAddProduct.Visible = false;
            }
            else if (currentEmp.Position == "manager")
            {
                btnEmployee.Visible = true;
                btnDepot.Visible = false;                
            }
            else if (currentEmp.Position == "shopworker")
            {
                btnEmployee.Visible = false;
                btnDepot.Visible = true;
                
                gbxAddProduct.Visible = false;
            }
            else
            {
                btnEmployee.Visible = false;
                btnDepot.Visible = true;               
            }

            // check checkboxes
            cbId.Checked = true;
            cbProduct.Checked = true;
            cbType.Checked = true;
            cbBrand.Checked = true;
            cbSpecifications.Checked = true;
            cbQuantity.Checked = true;
            cbPrice.Checked = true;
            cbShelf.Checked = true;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productname = tbxProduct.TextName.ToLower();
            string productType = tbxProductType.TextName.ToLower();
            string productBrand = tbxProductBrand.TextName.ToLower();
            string productSpecifications = tbxSpecifications.TextName.ToLower();
            uint productAmount = Convert.ToUInt32(nudQuantity.Value);
            double productPrice = Convert.ToDouble(nudPrice.Value);
            string shelfNumber = tbxShelfNumber.TextName.ToLower();

            if (productname == "" || productType == "" || productBrand == "" || productSpecifications == "" || shelfNumber == "" || productAmount <= 0 || productPrice <= 0)
            {
                MessageBox.Show("Please fill in all the fields!");
            }
            // check the strings
            else if (Regex.IsMatch(productname, @"^[0-9A-Za-z ]+$") == false)
            {
                MessageBox.Show("Invalid Product Name provided ! ! !");
            }
            else if (Regex.IsMatch(productType, @"^[A-Za-z ]+$") == false)
            {
                MessageBox.Show("Invalid Product Type provided ! ! !");
            }
            else if (Regex.IsMatch(productBrand, @"^[0-9A-Za-z ]+$") == false)
            {
                MessageBox.Show("Invalid Product Brand provided ! ! !");
            }
            //else if (Regex.IsMatch(productSpecifications, @"^[0 - 9A - Za - z] +$") == false)
            //{
            //    MessageBox.Show("Invalid Product Specifications provided ! ! !");
            //}
            else if (Regex.IsMatch(shelfNumber, @"^[0-9A-Za-z ]+$") == false)
            {
                MessageBox.Show("Invalid Shelf Number provided ! ! !");
            }
            else
            {
                Product product = new Product(productname, productType, productBrand, productSpecifications, productAmount, productPrice, shelfNumber);
                if (stockController.AddProduct(product))
                {
                    dgvProducts.DataSource = stockController.GetProducts();
                    MessageBox.Show("Product is succesfully added");

                    // clear textboxes
                    tbxProduct.TextName = "Product";
                    tbxProductType.TextName = "type";
                    nudQuantity.Value = 0;
                    tbxProductBrand.TextName = "Brand";
                    nudPrice.Value = 0;
                    tbxSpecifications.TextName = "Specifications";
                    tbxShelfNumber.TextName = "Shelf number";
                }
                else
                {
                    MessageBox.Show("You don't have permission");
                }
            }
        }

        private void btnRestockProduct_Click(object sender, EventArgs e)
        {
            if (nudAmount.Value < 1)
            {
                MessageBox.Show("Please select an amount you want to restock");
            }
            else if (dgvProducts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a product");
            }
            else
            {
                Product p = dgvProducts.SelectedRows[0].DataBoundItem as Product;
                stockController.RestockProduct(p, Convert.ToInt32(nudAmount.Value));
                dgvProducts.DataSource = stockController.GetProducts();
            }
        }

        private void btnSellUnits_Click_1(object sender, EventArgs e)
        {
            Product p = dgvProducts.SelectedRows[0].DataBoundItem as Product;

            if (nudAmount.Value > ProductDatabase.GetQuantityPerProduct(p.Id))// cannot sell more than the quantity
            {
                MessageBox.Show("Please select an amount you want to sell");
            }
            else if (dgvProducts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a product");
            }
            else
            {
                stockController.SellUnits(p.Id, Convert.ToInt32(nudAmount.Value));
                dgvProducts.DataSource = stockController.GetProducts();
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dgvProducts.DataSource = stockController.GetProducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tbxSearch.Text != "")
            {
                List<Product> temp = stockController.SearchProducts(tbxSearch.Text.ToLower());
                dgvProducts.DataSource = temp;
            }
            else
            {
                MessageBox.Show("Enter a valid search string.");
            }
        }

        //---------------- for nav bar
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentID);
            dashboard.Show();
            this.Close();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            Profile profile = new Profile(currentID);
            profile.Show();
            this.Close();
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            ViewEmployee viewEmployee = new ViewEmployee(currentID);
            viewEmployee.Show();
            this.Close();
        }

        private void btnDepot_Click_1(object sender, EventArgs e)
        {
            // thats this form
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        // manage checkboxes
        private void cbId_CheckedChanged(object sender, EventArgs e)
        {
            if (cbId.Checked)
            {
                dgvProducts.Columns["id"].Visible = true;
            }
            else
            {
                dgvProducts.Columns["id"].Visible = false;
            }
        }

        private void cbProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProduct.Checked)
            {
                dgvProducts.Columns["productname"].Visible = true;
            }
            else
            {
                dgvProducts.Columns["productname"].Visible = false;
            }
        }

        private void cbType_CheckedChanged(object sender, EventArgs e)
        {
            if (cbType.Checked)
            {
                dgvProducts.Columns["type"].Visible = true;
            }
            else
            {
                dgvProducts.Columns["type"].Visible = false;
            }
        }

        private void cbBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBrand.Checked)
            {
                dgvProducts.Columns["brand"].Visible = true;
            }
            else
            {
                dgvProducts.Columns["brand"].Visible = false;
            }
        }

        private void cbSpecifications_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSpecifications.Checked)
            {
                dgvProducts.Columns["specifications"].Visible = true;
            }
            else
            {
                dgvProducts.Columns["specifications"].Visible = false;
            }
        }

        private void cbQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQuantity.Checked)
            {
                dgvProducts.Columns["quantity"].Visible = true;
            }
            else
            {
                dgvProducts.Columns["quantity"].Visible = false;
            }
        }

        private void cbPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrice.Checked)
            {
                dgvProducts.Columns["price"].Visible = true;
            }
            else
            {
                dgvProducts.Columns["price"].Visible = false;
            }
        }

        private void cbShelf_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShelf.Checked)
            {
                dgvProducts.Columns["shelfnumber"].Visible = true;
            }
            else
            {
                dgvProducts.Columns["shelfnumber"].Visible = false;
            }
        }
    }
}
