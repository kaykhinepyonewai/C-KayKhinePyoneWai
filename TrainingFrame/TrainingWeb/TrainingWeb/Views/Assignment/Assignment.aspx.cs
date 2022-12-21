using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Training.Entities.Assignment;
using Training.Entities.Student;
using Training.Services.Assignment;
using Training.Services.Student;

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
                Response.Redirect("~/Views/Assignment/AssignmetnList.aspx");
            }
        }

        public AssignmentEntity CreateData()
        {
            AssignmentEntity assignmentEntity = new AssignmentEntity();
            assignmentEntity.assignmentid = Convert.ToInt32(hdAssignmentId.Value);
            assignmentEntity.studentname = txtStudentName.Text;
            assignmentEntity.teachername = txtTeacherName.Text;
            assignmentEntity.assignmentname = txtAssignmentName.Text;
            assignmentEntity.classname = txtClassName.Text;

            assignmentEntity.remark = txtRemark.Text;

            string[] date = txtFinishedDate.Text.Split('/');
            assignmentEntity.finisheddate = Convert.ToDateTime(date[2] + "-" + date[1] + "-" + date[0]);

            return assignmentEntity;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Assignment/AssignmetnList.aspx");
        }

      
    }
}