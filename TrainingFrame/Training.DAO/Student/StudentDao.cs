using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Training.DAO.Common;
using Training.Entities.Student;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Training.DAO.Student
{
    public class StudentDao
    {
        private DbConnection connection = new DbConnection();

        private string strSql = String.Empty;

        private DataTable resultDataTable = new DataTable();

        private int existCount;

       
        public DataTable GetAll()
        {
            strSql = "SELECT * FROM Students ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert (StudentEntity studentEntity)
        {
            strSql = "INSERT INTO Students(Name,Address,CourseName,CourseFee,JoiningDate)" + "VALUES(@Name,@Address,@CourseName,@CourseFee,@JoiningDate)";

            SqlParameter[] sqlParam =
            {
                new SqlParameter("@Name",studentEntity.name),
                new SqlParameter("@Address", studentEntity.address),
                new SqlParameter("@CourseName",studentEntity.coursename),
                new SqlParameter("@CourseFee",studentEntity.coursefee),
                new SqlParameter("@JoiningDate",studentEntity.joningdate)

            };
             bool success = connection.ExecuteNonQuery(CommandType.Text,strSql, sqlParam);
             return success;
        }
        
        public bool Update(StudentEntity studentEntity)
        {
            strSql = "UPDATE Students SET Name=@Name,Address=@Address,CourseName=@CourseName,CourseFee=@CourseFee,JoiningDate=@JoiningDate WHERE StudentId= @StudentId";

            SqlParameter[] sqlParam =
                 {
                    new SqlParameter("@StudentId",studentEntity.studentid),
                    new SqlParameter("@Name",studentEntity.name),
                    new SqlParameter("@Address",studentEntity.address),
                    new SqlParameter("@CourseName",studentEntity.coursename),
                    new SqlParameter("@CourseFee",studentEntity.coursefee),
                    new SqlParameter("@JoiningDate",studentEntity.joningdate)
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }


        public DataTable Get(int id)
        {
            strSql = "SELECT * FROm Students Where StudentId = " +id;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }


        public bool Delete(int id)
        {
            strSql = "DELETE FROM Students WHERE StudentId = @StudentId";
            SqlParameter[] sqlParam =
            {
                new SqlParameter("@StudentId",id)
            };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
    }
}
