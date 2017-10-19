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

            
            if (Session["User"] != null)
            {
                Customer user = (Customer)Session["User"];
                LoggedInLabel.Text = $"Logged in as {user.Email}";
            }

        }

        protected void ButtonMedlem_Click(object sender, EventArgs e)
        {
            Response.Redirect("/CreateCustomer.aspx");
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == "admin" && TextBoxPassword.Text == "admin")
            {
                Response.Redirect("/AdminPage.aspx");
            }
            else
            {
                foreach (Customer customer in customers)
                {
                    if (TextBoxEmail.Text == customer.Email && TextBoxPassword.Text == customer.Password)
                    {
                        Session["User"] = customer;
                        LoggedInLabel.Text = $"Logged in as {customer.Email}";
                        break;
                    }
                }
            }
        }

       
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}