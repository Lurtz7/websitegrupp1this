using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibrary;

namespace Webstore
{
    public partial class CreateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateCust_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(0, textBoxFirstname.Text, textBoxLastname.Text, textBoxSSN.Text, textBoxEmail.Text, textBoxPassword.Text);

            int cid = MySql.CreateContact(customer);

            Address address = new Address(0, textBoxStreet.Text, textBoxCity.Text, textBoxZIP.Text, textBoxCountry.Text);

            int aid = MySql.CreateAddress(address);

            int c2a = MySql.C2A(cid, aid);

        }

    }
}