using System;
using System.Data;
using Training.Entities.Assignment;
using Training.Services.Assignment;

namespace TrainingWeb.Views.Assignment
{
    public partial class Assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    btnSave.Text = "Update";
                    hdAssignmentId.Value = Request.QueryString["id"].ToString();
                    BindData();
                }
            }
        }

        void BindData()
        {
            AssignmentService assignmentService = new AssignmentService();
            DataTable dt = assignmentService.Get(Convert.ToInt32(hdAssignmentId.Value));
            if(dt.Rows.Count > 0)
            {
                txtStudentName.Text = dt.Rows[0]["StudentName"].ToString();
                txtTeacherName.Text = dt.Rows[0]["TeacherName"].ToString();
                txtAssignmentName.Text = dt.Rows[0]["AssignmentName"].ToString();
                txtClassName.Text = dt.Rows[0]["ClassName"].ToString();
                txtRemark.Text = dt.Rows[0]["Remark"].ToString();
                txtFinishedDate.Text = Convert.ToDateTime(dt.Rows[0]["FinishedDate"]).ToString("dd/MM/yyyy");

            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AddorUpdate();
        }

        void AddorUpdate()
        {
            AssignmentService studentService = new AssignmentService();
            AssignmentEntity studentEntity = CreateData();
            bool success = false;
            if (hdAssignmentId.Value == "0")
            {
                success = studentService.Insert(studentEntity);
            }
            else
            {
                success = studentService.Update(studentEntity);
            }

            if (success)
            {
                Response.Redirect("~/Views/Assignment/AssignmentList.aspx");
            }
        }

        public AssignmentEntity CreateData()
        {
            AssignmentEntity assignmentEntity = new AssignmentEntity();
            assignmentEntity.AssignmentId = Convert.ToInt32(hdAssignmentId.Value);
            assignmentEntity.StudentName = txtStudentName.Text;
            assignmentEntity.TeacherName = txtTeacherName.Text;
            assignmentEntity.AssignmentName = txtAssignmentName.Text;
            assignmentEntity.ClassName = txtClassName.Text;

            assignmentEntity.Remark = txtRemark.Text;

            string[] date = txtFinishedDate.Text.Split('/');
            assignmentEntity.FinishedDate = Convert.ToDateTime(date[2] + "-" + date[1] + "-" + date[0]);

            return assignmentEntity;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Assignment/AssignmentList.aspx");
        }

      
    }
}