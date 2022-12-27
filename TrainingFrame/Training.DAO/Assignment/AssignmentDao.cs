using System;
using Training.DAO.Common;
using Training.Entities.Assignment;
using System.Data;
using System.Data.SqlClient;

namespace Training.DAO.Assignment
{
    public class AssignmentDao
    {
        private DbConnection connection = new DbConnection();

        private string strSql = String.Empty;

        public DataTable GetAll()
        {
            strSql = "SELECT * FROM Assignment ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM Assignment WHERE AssignmentId=" + id;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert(AssignmentEntity assignmentEntity)
        {
            strSql = "INSERT INTO Assignment(StudentName,TeacherName,AssignmentName,ClassName,Remark,FinishedDate)" + "VALUES(@StudentName,@TeacherName,@AssignmentName,@ClassName,@Remark,@FinishedDate)";

            SqlParameter[] sqlParam =
            {
                new SqlParameter("@StudentName",assignmentEntity.StudentName),
                new SqlParameter("@TeacherName",assignmentEntity.TeacherName),
                new SqlParameter("@AssignmentName",assignmentEntity.AssignmentName),
                new SqlParameter("@ClassName",assignmentEntity.ClassName),
                new SqlParameter("@Remark",assignmentEntity.Remark),
                new SqlParameter("@FinishedDate",assignmentEntity.FinishedDate)
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        public bool Update(AssignmentEntity assignmentEntity)
        {
            strSql = "UPDATE Assignment SET StudentName=@StudentName,TeacherName=@TeacherName,AssignmentName=@AssignmentName,ClassName=@ClassName,Remark=@Remark,FinishedDate=@FinishedDate WHERE AssignmentId=@AssignmentId";

            SqlParameter[] sqlParam =
            {
                new SqlParameter("@AssignmentId",assignmentEntity.AssignmentId),
                new SqlParameter("@StudentName",assignmentEntity.StudentName),
                new SqlParameter("@TeacherName",assignmentEntity.TeacherName),
                new SqlParameter("@AssignmentName",assignmentEntity.AssignmentName),
                new SqlParameter("@ClassName",assignmentEntity.ClassName),
                new SqlParameter("@Remark",assignmentEntity.Remark),
                new SqlParameter("@FinishedDate",assignmentEntity.FinishedDate)
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        public bool Delete(int id)
        {
            strSql = "DELETE FROM Assignment WHERE AssignmentId=@AssignmentId";
            SqlParameter[] sqlParam =
            {
                new SqlParameter("@AssignmentId",id)
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;

        }
    }
}
