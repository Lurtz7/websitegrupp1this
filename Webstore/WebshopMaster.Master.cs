using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibrary;

namespace Webstore
{
    public partial class WebshopMaster : System.Web.UI.MasterPage
    {
        List<Customer> customers;
        protected void Page_Load(object sender, EventArgs e)
        {
            customers = MySql.ReadCustomers();
        }

        protected void ButtonMedlem_Click(object sender, EventArgs e)
        {
            Response.Redirect("/CreateCustomer.aspx");
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            bool login = false;
            bool adminLogin = false;

            if (ButtonLogin.Text == "Logga in") {
                string username = String.Format("{0}", Request.Form["email"]);
                string password = String.Format("{0}", Request.Form["password"]);
                for (int i = 0; i < customers.Count; i++)
                {
                    if (username == customers[i].Email && password == customers[i].Password)
                    {
                        login = true;
                        break;
                    }
                }
                if (login)
                {
                    if (username == "admin")
                    {
                        adminLogin = true;
                        // Länka till AdminPage.aspx
                        Response.Redirect("/AdminPage.aspx");
                    }

                    else
                    {
                        // Sätt "inloggad" till användarnamn
                        ButtonLogin.Text = "Logga ut";
                    }
                }
            }
            if(ButtonLogin.Text == "Logga ut")
            {
                ButtonLogin.Text = "Logga in";
                //... logga ut
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}