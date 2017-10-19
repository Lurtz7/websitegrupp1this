using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibrary;

namespace Webstore
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();

            if (Session["productList"] != null)
                products = (List<Product>)Session["productList"];

            foreach (var product in products)
            {
                ListBoxCart.Items.Add(" ---------" + product.Soldnr + " -------------------------------------" + product.ID.ToString() + " -------------------------------------------------------------------------------------------------" + product.Price.ToString() + " Kr");
               
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            Session["productList"] = null;
            Response.Redirect("/ShoppingCart.aspx");
        }
    }
}