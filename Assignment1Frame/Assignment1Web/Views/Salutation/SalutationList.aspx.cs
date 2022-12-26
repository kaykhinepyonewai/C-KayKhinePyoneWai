using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment1.Services.Salutation;

namespace Assignment1Web.Views.Salutation
{
    public partial class SalutationList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            
            SalutaionService assignment1Service = new SalutaionService();
            DataTable dt = assignment1Service.GetAll();

            gvSalutation.DataSource = dt;
            gvSalutation.DataBind();

        }

        protected void lnkbtnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Salutation/Salutation.aspx");
        }

        protected void gvSalutation_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Edit")
            {
                Response.Redirect("~/Views/Salutation/Salutation.aspx?id=" + e.CommandArgument);
                
            }
        }

        protected void gvSalutation_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblSalutationId = (Label)gvSalutation.Rows[e.RowIndex].FindControl("lblSalutationId");

           
            SalutaionService salutaionService = new SalutaionService();

            Response.Write("<script>confirm('Data has Deleted....')</script>");
            bool success = salutaionService.Delete(Convert.ToInt32(lblSalutationId.Text));

            if(success)
            {
                BindData();
            }
            else
            {
                //lblMessage.Text = e.ToString();
            }
        }

    }
}
