using System;
using System.Data;
using Training.Entities.Student;
using Training.Services.Student;

namespace TrainingWeb.Views.Student
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
              
            {
                if (Request.QueryString["id"] !=null)
                {
                    btnSave.Text = "Update";
                    hdStudentId.Value = Request.QueryString["id"].ToString();
                    BindData();
                }
               
            }
        }

        void BindData()
        {
            StudentService studentService = new StudentService();

            DataTable dt = studentService.Get(Convert.ToInt32(hdStudentId.Value));
            if(dt.Rows.Count>0)
            {
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtCourseName.Text = dt.Rows[0]["CourseName"].ToString();
                txtCourseFee.Text = dt.Rows[0]["CourseFee"].ToString();
                txtJoiningDate.Text = Convert.ToDateTime(dt.Rows[0]["JoiningDate"]).ToString("dd/MM/yyyy");

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AddorUpdate();
        }

        void AddorUpdate()
        {
           
            StudentService studentService = new StudentService();
            StudentEntity studentEntity = CreateData();
            bool success = false;
            if(hdStudentId.Value == "0")
            {
                success = studentService.Insert(studentEntity);
            }
            else
            {
                success = studentService.Update(studentEntity);
            }

            if(success)
            {
                Response.Redirect("~/Views/Student/StudentList.aspx");
            }
        }

        public StudentEntity CreateData()
        {
          
            StudentEntity studentEntity = new StudentEntity();
            studentEntity.StudentId = Convert.ToInt32(hdStudentId.Value);
            studentEntity.Name = txtName.Text;
            studentEntity.Address = txtAddress.Text;
            studentEntity.CourseName = txtCourseName.Text;
            studentEntity.CourseFee = txtCourseFee.Text == "" ? 0 : Convert.ToInt32(txtCourseFee.Text);

            string[] date = txtJoiningDate.Text.Split('/');

            studentEntity.JoningDate = Convert.ToDateTime(date[2] + "-" + date[1] + "-" + date[0]);

            return studentEntity;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Student/StudentList.aspx");
        }
    }
}