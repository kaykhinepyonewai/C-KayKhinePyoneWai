using Assignment2.Services.Salutation;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Assignment2Web.Views.Salutation
{
    public partial class SalutationList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {

            SalutationService assignment1Service = new SalutationService();
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
            if (e.CommandName == "Edit")
            {
                Response.Redirect("~/Views/Salutation/Salutation.aspx?id=" + e.CommandArgument);

            }
        }

        protected void gvSalutation_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblSalutationId = (Label)gvSalutation.Rows[e.RowIndex].FindControl("lblSalutationId");
            SalutationService salutaionService = new SalutationService();


            bool success = salutaionService.Delete(Convert.ToInt32(lblSalutationId.Text));

            if (success)
            {
                BindData();
            }

        }
    }
}