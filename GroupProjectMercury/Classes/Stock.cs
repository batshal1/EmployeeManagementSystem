using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class Stock
    {
        private List<Product> products = new List<Product>();

        public Stock()
        {
            products = ProductDatabase.GetAllProductsFromDB();
        }

        public List<Product> GetProducts()
        {
            products = ProductDatabase.GetAllProductsFromDB();
            return products;
        }


        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
