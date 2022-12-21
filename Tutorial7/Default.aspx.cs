using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tutorial7
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.ToString() == "12345")
            {
                Session["Gmail"] = txtGamil.Text.ToString();
                Session["Password"] = txtPassword.Text.ToString();
                Response.Redirect("Home.aspx");
            }
            else
            {
                errorMSG.Text = "Invlaid email or password";
                errorMSG.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}