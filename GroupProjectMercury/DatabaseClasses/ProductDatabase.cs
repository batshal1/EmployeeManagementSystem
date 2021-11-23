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
    public static class ProductDatabase
    {
        // 'products'
        public static bool AddProductToDB(Product p)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SET FOREIGN_KEY_CHECKS=0;" +
                    "INSERT INTO `products`(`product`, `type`, `brand`, `specifications`, `quantity`,`price`, `shelfnumber`) VALUES (@product,@type,@brand,@specifications,@quantity,@price,@shelfnumber);" +
                    "SET FOREIGN_KEY_CHECKS=1;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@product", p.Productname);
                cmd.Parameters.AddWithValue("@type", p.Type);
                cmd.Parameters.AddWithValue("@brand", p.Brand);
                cmd.Parameters.AddWithValue("@specifications", p.Specifications);
                cmd.Parameters.AddWithValue("@quantity", p.Quantity);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.Parameters.AddWithValue("@shelfnumber", p.ShelfNumber);
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

        public static List<Product> GetAllProductsFromDB()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM products";
                List<Product> allProducts = new List<Product>();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string productname = dataReader[1].ToString();
                    string type = dataReader[2].ToString();
                    string brand = dataReader[3].ToString();
                    string specifications = dataReader[4].ToString();
                    uint quantity = Convert.ToUInt32(dataReader[5]);
                    double price = Convert.ToDouble(dataReader[6]);
                    string shelfNumber = dataReader[7].ToString();

                    allProducts.Add(new Product(id, productname, type, brand, specifications, quantity, price, shelfNumber));
                }
                dataReader.Close();
                connection.Close();
                return allProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Product>();
            }
        }

        public static void IncreaseQuantityOfProduct(Product p, int addAm)
        {
            try
            {
                int amount = Convert.ToInt32(p.Quantity) + addAm;
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE products SET quantity = @amount WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@id", p.Id);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void DecreaseQuantityOfProduct(int id, int amount)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "UPDATE products SET quantity = quantity - @amount WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@amount", amount);
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

        public static int GetQuantityPerProduct(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT quantity FROM products WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                int quantity = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                return quantity;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public static List<Product> SearchProducts(string text)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi448360;Database=dbi448360;Pwd=123456;");
                string sql = "SELECT * FROM products WHERE CONCAT(id, product,type, brand, specifications, quantity, price, shelfnumber) LIKE '%" + text + "%'";
                List<Product> allProducts = new List<Product>();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string productname = dataReader[1].ToString();
                    string type = dataReader[2].ToString();
                    string brand = dataReader[3].ToString();
                    string specifications = dataReader[4].ToString();
                    uint quantity = Convert.ToUInt32(dataReader[5]);
                    double price = Convert.ToDouble(dataReader[6]);
                    string shelfNumber = dataReader[7].ToString();

                    allProducts.Add(new Product(id, productname, type, brand, specifications, quantity, price, shelfNumber));
                }
                dataReader.Close();
                connection.Close();
                return allProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new List<Product>();
            }
        }
    }
}
