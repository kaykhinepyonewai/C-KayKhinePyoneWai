using System;
using Training.DAO.Common;
using Training.Entities.Student;
using System.Data;
using System.Data.SqlClient;

namespace Training.DAO.Student
{
    public class StudentDao
    {
        private DbConnection connection = new DbConnection();

        private string strSql = String.Empty;

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
                new SqlParameter("@Name",studentEntity.Name),
                new SqlParameter("@Address", studentEntity.Address),
                new SqlParameter("@CourseName",studentEntity.CourseName),
                new SqlParameter("@CourseFee",studentEntity.CourseFee),
                new SqlParameter("@JoiningDate",studentEntity.JoningDate)

            };
             bool success = connection.ExecuteNonQuery(CommandType.Text,strSql, sqlParam);
             return success;
        }
        
        public bool Update(StudentEntity studentEntity)
        {
            strSql = "UPDATE Students SET Name=@Name,Address=@Address,CourseName=@CourseName,CourseFee=@CourseFee,JoiningDate=@JoiningDate WHERE StudentId= @StudentId";

            SqlParameter[] sqlParam =
                 {
                    new SqlParameter("@StudentId",studentEntity.StudentId),
                    new SqlParameter("@Name",studentEntity.Name),
                    new SqlParameter("@Address",studentEntity.Address),
                    new SqlParameter("@CourseName",studentEntity.CourseName),
                    new SqlParameter("@CourseFee",studentEntity.CourseFee),
                    new SqlParameter("@JoiningDate",studentEntity.JoningDate)
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
