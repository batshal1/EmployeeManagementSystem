using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class Product
    {
        public static int idSeeder = 1;
        private int id;

        public int Id { get; set; }
        public string Productname { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Specifications { get; set; }
        public uint Quantity { get; set; }
        public double Price { get; set; }
        public string ShelfNumber { get; set; }

        public Product(string productname, string type, string brand, string specifications, uint quantity, double price, string shelfNumber)
        {
            id = idSeeder++;
            this.Productname = productname;
            this.Type = type;
            this.Brand = brand;
            this.Specifications = specifications;
            this.Quantity = quantity;
            this.Price = price;
            this.ShelfNumber = shelfNumber;
        }

        public Product(int id,string productname, string type, string brand, string specifications, uint quantity, double price, string shelfNumber)
        {
            //id = idSeeder++;
            this.Id = id;
            this.Productname = productname;
            this.Type = type;
            this.Brand = brand;
            this.Specifications = specifications;
            this.Quantity = quantity;
            this.Price = price;
            this.ShelfNumber = shelfNumber;
        }


        public override string ToString()
        {
            return $"ID: {Id} type: {Type} price: {Price} quantity: {Quantity}";
        }
    }
}
