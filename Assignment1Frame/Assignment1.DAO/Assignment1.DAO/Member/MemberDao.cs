using Assignment1.DAO.Common;
using Assignment1.Entities.Member;
using Assignment1.Entities.Salutation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.DAO.Member
{
    public class MemberDao
    {
        private DBConnection connection = new DBConnection();

        private string strSql = String.Empty;

        private DataTable resultDataTable = new DataTable();

        private int existCount;

        public DataTable GetAll()
        {
            strSql = "select * from Member,Salutation WHERE Member.SalutationId=Salutation.SalutationId";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable Get(int id)
        {
            strSql = "select * from Member,Salutation WHERE Member.MemberId=" + id + " and Member.SalutationId=Salutation.SalutationId";
            return connection.ExecuteDataTable(CommandType.Text, strSql);

        }

        public bool Insert(MemberEntity memberEntity)
        {
           
            strSql = "INSERT INTO Member(FullName,Address,SalutationId) " + "VALUES (@FullName,@Address,@SalutationId)";
            SqlParameter[] sqlPara =
            {
                new SqlParameter("@FullName",memberEntity.fullname),
                new SqlParameter("@Address",memberEntity.address),
                new SqlParameter("@SalutationId",memberEntity.salutationid)

            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }

        public bool Update(MemberEntity memberEntity)
        {
            strSql = "UPDATE Member SET FullName=@FullName,Address=@Address,SalutationId=@SalutationId WHERE MemberId=@MemberId";
            SqlParameter[] sqlPara =
            {
                 new SqlParameter("@FullName",memberEntity.fullname),
                new SqlParameter("@Address",memberEntity.address),
                new SqlParameter("@SalutationId",memberEntity.salutationid),
                new SqlParameter("@MemberId",memberEntity.memberid),

            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }

        public int Count(MemberEntity memberEntity)
        {
            strSql = "SELECT COUNT(*) FROM Member WHERE FullName=" + "@FullName";
            SqlParameter[] sqlPara =
           {
                 new SqlParameter("@FullName",memberEntity.fullname),
            };

            int sucess = Convert.ToInt32(connection.ExecuteScalar(CommandType.Text, strSql, sqlPara));

            return sucess;
        }

        public DataTable GetSalutation()
        {
            strSql = "select * from Salutation";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Delete(int id)
        {
            strSql = "DELETE FROM Member WHERE MemberId=@MemberId";

            SqlParameter[] sqlPara =
            {
                new SqlParameter("@MemberId",id)
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }


    }
}
