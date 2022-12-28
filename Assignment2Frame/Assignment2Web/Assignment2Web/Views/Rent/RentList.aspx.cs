using Assignment2.Services.Rent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Web.Views.Rent
{
    public partial class RentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            RentService rentServiece = new RentService();
            DataTable dt = rentServiece.GetAll();
            gvRent.DataSource = dt;
            gvRent.DataBind();
        }

        protected void lnkbtnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Rent/Rent.aspx");
        }

        protected void gvRent_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("~/Views/Rent/Rent.aspx?id=" + e.CommandArgument);

            }
        }

        protected void gvRent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblRentedId = (Label)gvRent.Rows[e.RowIndex].FindControl("lblRentedId");


            RentService rentService = new RentService();
            bool success = rentService.Delete(Convert.ToInt32(lblRentedId.Text));

            if (success)
            {
                BindData();
            }

        }
    }
}