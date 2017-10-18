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
            LabelInvalidEmailVerif.Visible = false;
            LabelInvalidPasswordVerif.Visible = false;

            if (textBoxPassword.Text.Trim().Length > 0 &&
                textBoxPassword.Text.CompareTo(textBoxPasswordVerify.Text) == 0 &&
                textBoxEmail.Text.Trim().Length > 0 &&
                textBoxEmail.Text.CompareTo(textBoxEmailVerify.Text) == 0 &&
                textBoxFirstname.Text.Trim().Length > 0 &&
                textBoxLastname.Text.Trim().Length > 0 &&
                textBoxSSN.Text.Trim().Length > 0 &&
                textBoxStreet.Text.Trim().Length > 0 &&
                textBoxCity.Text.Trim().Length > 0 &&
                textBoxZIP.Text.Trim().Length > 0 &&
                textBoxCountry.Text.Trim().Length > 0
                )
            {
                Customer customer = new Customer(0, textBoxFirstname.Text, textBoxLastname.Text, textBoxSSN.Text, textBoxEmail.Text, textBoxPassword.Text);

                int cid = MySql.CreateContact(customer);

                Address address = new Address(0, textBoxStreet.Text, textBoxCity.Text, textBoxZIP.Text, textBoxCountry.Text);

                int aid = MySql.CreateAddress(address);

                int c2a = MySql.C2A(cid, aid);
            }
            else
            {
                if (textBoxEmail.Text.CompareTo(textBoxEmailVerify.Text) != 0)
                    LabelInvalidEmailVerif.Visible = true;
                if (textBoxPassword.Text.CompareTo(textBoxPasswordVerify.Text) != 0)
                    LabelInvalidPasswordVerif.Visible = true;

            }
        }

        protected void ButtonAvbryt_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ïndex.aspx");
        }
    }
}