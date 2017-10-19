using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibrary;

namespace Webstore
{
    public partial class pageProduct : System.Web.UI.Page
    {
        static List<int> ids = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["id"] != null)
            {
                int id = int.Parse(Request["id"].ToString());

                SQLLibrary.Product product = SQLLibrary.MySql.ReadProducts().FirstOrDefault(x => x.ID == id);

                labelProductInfo.Text = product.ProductDescription;
                ImageProduct.ImageUrl = product.PictureUrl;
                labelProductPrice.Text = "Produktnamn: " + product.Soldnr.ToString() + "<br/>" + "<br/>" +
                    "Artikelnummer: " + product.ID.ToString() + "<br/>" + "<br/>" + "<br/>" + "<br/>" +
                   "Pris: " + product.Price.ToString();
                
            }
        }

        protected void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                int numberOfCartItems;

                int id = int.Parse(Request["id"].ToString());
                SQLLibrary.Product product = SQLLibrary.MySql.ReadProducts().FirstOrDefault(x => x.ID == id);

                List<Product> products = new List<Product>();
                if (Session["productList"] != null)
                    products = (List<Product>)Session["productList"];

                products.Add(product);

                Session["productList"] = products;

               
            }
        }
    }
}