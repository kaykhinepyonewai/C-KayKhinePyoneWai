using Training.Services.Student;
using System;
using System.Web.UI.WebControls;
using System.Data;

namespace TrainingWeb.Views.Student
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            StudentService studentService = new StudentService();
            DataTable dt = studentService.GetAll();

            gvStudent.DataSource = dt;
            gvStudent.DataBind();

        }

        protected void lnkbtnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Student/Student.aspx");
        }

        protected void gvStudent_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect("~/Views/Student/Student.aspx?id=" + e.CommandArgument);
            }
        }

        protected void gvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            Label lblStudentID = (Label)gvStudent.Rows[e.RowIndex].FindControl("lblStudentID");

            StudentService studentService = new StudentService();
            Response.Write("<script>confirm('Are You Sure You Want To Delete.....')</script>");

            bool success = studentService.Delete(Convert.ToInt32(lblStudentID.Text));

            if (success)
            {
                BindData();
            }
        }

       
    }
}