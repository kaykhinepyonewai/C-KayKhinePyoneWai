using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tutorial7
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Gmail"] == null)
            {
                LoginPlaceHolder1.Visible = true;
                LogoutPlaceHolder1.Visible = false;
            }
            else
            {
                LoginPlaceHolder1.Visible = false;
                LogoutPlaceHolder1.Visible = true;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("Default.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}