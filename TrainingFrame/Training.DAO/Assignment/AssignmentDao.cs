using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Training.DAO.Common;
using Training.Entities.Assignment;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Training.Entities.Student;
using System.Windows.Markup;

namespace Training.DAO.Assignment
{
    public class AssignmentDao
    {
        private DbConnection connection = new DbConnection();

        private string strSql = String.Empty;

        private DataTable resultDataTable = new DataTable();

        private int existCount;


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
                new SqlParameter("@StudentName",assignmentEntity.studentname),
                new SqlParameter("@TeacherName",assignmentEntity.teachername),
                new SqlParameter("@AssignmentName",assignmentEntity.assignmentname),
                new SqlParameter("@ClassName",assignmentEntity.classname),
                new SqlParameter("@Remark",assignmentEntity.remark),
                new SqlParameter("@FinishedDate",assignmentEntity.finisheddate)
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        public bool Update(AssignmentEntity assignmentEntity)
        {
            strSql = "UPDATE Assignment SET StudentName=@StudentName,TeacherName=@TeacherName,AssignmentName=@AssignmentName,ClassName=@ClassName,Remark=@Remark,FinishedDate=@FinishedDate WHERE AssignmentId=@AssignmentId";

            SqlParameter[] sqlParam =
            {
                new SqlParameter("@AssignmentId",assignmentEntity.assignmentid),
                new SqlParameter("@StudentName",assignmentEntity.studentname),
                new SqlParameter("@TeacherName",assignmentEntity.teachername),
                new SqlParameter("@AssignmentName",assignmentEntity.assignmentname),
                new SqlParameter("@ClassName",assignmentEntity.classname),
                new SqlParameter("@Remark",assignmentEntity.remark),
                new SqlParameter("@FinishedDate",assignmentEntity.finisheddate)
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
