using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLibrary
{
    public class Product
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string PictureUrl { get; set; }
        public int Stocknr { get; set; }
        public int Soldnr { get; set; }
        public string ProductDescription { get; set; }

        // A user should never be created without username/password etc
        private Product()
        {

        }

        public Product(int id, int price, string pictureUrl, int stocknr, int soldnr, string productDescription)
        {
            ID = id;
            Price = price;
            PictureUrl = pictureUrl;
            Stocknr = stocknr;
            Soldnr = soldnr;
            ProductDescription = productDescription;
        }

        public override string ToString()
        {
            return $"{ID}, {Price}, {PictureUrl}, {Stocknr} {Soldnr}, {ProductDescription}";
        }
    }
}
