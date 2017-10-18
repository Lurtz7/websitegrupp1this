using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using SQLLibrary;

namespace Webstore.Service
{
    public partial class productServices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = MySql.ReadProducts();

            productsLiteral.Text = JsonConvert.SerializeObject(products);

        }
    }
}