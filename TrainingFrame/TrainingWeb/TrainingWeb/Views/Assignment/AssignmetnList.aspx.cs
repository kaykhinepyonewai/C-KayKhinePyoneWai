using System;
using System.Data;
using System.Web.UI.WebControls;
using Training.Services.Assignment;


namespace TrainingWeb.Views.Assignment
{
    public partial class AssignmetnList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
       {
            BilndData();
        }

        void BilndData()
        {
            AssignmentService assignmentService = new AssignmentService();
            DataTable dt = assignmentService.GetAll();

            gvAssignment.DataSource = dt;
            gvAssignment.DataBind();
        }

        protected void lnkbtnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Assignment/Assignment.aspx");

        }

        protected void gvAssignment_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Edit")
            {
                Response.Redirect("~/Views/Assignment/Assignment.aspx?id=" + e.CommandArgument);
            }
        }

        protected void gvAssignment_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblAssignmentId = (Label)gvAssignment.Rows[e.RowIndex].FindControl("lblAssignmentId");

            AssignmentService assignmentService = new AssignmentService();

            Response.Write("<script>confirm('Are You Sure You Want To Delete ....')</script>");
            bool success = assignmentService.Delete(Convert.ToInt32(lblAssignmentId.Text));

            if(success)
            {
                BilndData();
            }
        }
    }
}