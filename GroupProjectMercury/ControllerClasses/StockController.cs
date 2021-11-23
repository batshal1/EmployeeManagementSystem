using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class StockController
    {
        private int currentId;
        private Employee currentEmp;
        private Stock stock;
        private Permissions permissions;

        public StockController(int id)
        {
            currentId = id;
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentId);
            stock = new Stock();
            permissions = new Permissions(currentEmp);
        }

        // products
        public List<Product> GetProducts()
        {
            bool test = permissions.GetPermission(Util.GET_PRODUCTS);
            if (test)
            {
                return stock.GetProducts();
            }
            else
            {
                return null;
            }
        }

        public bool AddProduct(Product product)
        {
            if (permissions.GetPermission(Util.ADD_PRODUCT))
            {
                stock.AddProduct(product);
                ProductDatabase.AddProductToDB(product);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RestockProduct(Product p, int amount)
        {
            if (permissions.GetPermission(Util.RESTOCK_PRODUCT))
            {
                ProductDatabase.IncreaseQuantityOfProduct(p, amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SellUnits(int id, int amount)
        {
            if (permissions.GetPermission(Util.RESTOCK_PRODUCT))
            {
                ProductDatabase.DecreaseQuantityOfProduct(id, amount);
                return true;
            }
            else
            {
                return false;
            }
        }


        // products: search
        public List<Product> SearchProducts(string text)
        {
            if (permissions.GetPermission(Util.SEARCH_PRODUCTS))
            {
                return ProductDatabase.SearchProducts(text);
            }
            else
            {
                return null;
            }
        }


    }
}
