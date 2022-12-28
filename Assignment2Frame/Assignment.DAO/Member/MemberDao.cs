using Assignment.DAO.Common;
using Assignment2.Entities.Member;
using System;
using System.Data;
using System.Data.SqlClient;
namespace Assignment.DAO.Member
{
    public class MemberDao
    {
        private DBConnection connection = new DBConnection();

        private string strSql = String.Empty;

        public DataTable GetAll()
        {

            strSql = "select * from ((Member as m INNER JOIN Rent as r ON m.RentedId = r.RentedId) INNER JOIN Salutation as s ON m.SalutationId=s.SalutationId)";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable GetAllExport()
        {

            strSql = "select m.FullName,m.Address,r.MovieRented,s.Salutation from ((Member as m INNER JOIN Rent as r ON m.RentedId = r.RentedId) INNER JOIN Salutation as s ON m.SalutationId=s.SalutationId)";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert(MemberEntity memberEntity)
        {

            strSql = "INSERT INTO Member(FullName,Address,SalutationId,RentedId) " + "VALUES (@FullName,@Address,@SalutationId,@RentedId)";
            SqlParameter[] sqlPara =
            {
                new SqlParameter("@FullName",memberEntity.FullName),
                new SqlParameter("@Address",memberEntity.Address),
                new SqlParameter("@SalutationId",memberEntity.SalutationId),
                new SqlParameter("@RentedId",memberEntity.RentedId)

            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }


        public int TakeSalutationId(string salutaionName)
        { 
            strSql = "SELECT SalutationId  FROM Salutation WHERE Salutation=" + "@Salutation";
            SqlParameter[] sqlPara =
           {
                 new SqlParameter("@Salutation",salutaionName),
            };

            int sucess = Convert.ToInt32(connection.ExecuteScalar(CommandType.Text, strSql, sqlPara));

            return sucess;
        }

        public int TakeRentedId(string MovieRented)
        {
            strSql = "SELECT RentedId  FROM Rent WHERE MovieRented=" + "@MovieRented";
            SqlParameter[] sqlPara =
           {
                 new SqlParameter("@MovieRented",MovieRented),
            };

            int sucess = Convert.ToInt32(connection.ExecuteScalar(CommandType.Text, strSql, sqlPara));

            return sucess;
        }

        public DataTable Get(int id)
        {
            strSql = "select * from Member,Salutation,Rent WHERE Member.MemberId=" + id + " and Member.SalutationId=Salutation.SalutationId and Member.RentedId = Rent.RentedId";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Update(MemberEntity memberEntity)
        {
            strSql = "UPDATE Member SET FullName=@FullName,Address=@Address,SalutationId=@SalutationId,RentedId=@RentedId WHERE MemberId=@MemberId";
            SqlParameter[] sqlPara =
            {
                 new SqlParameter("@FullName",memberEntity.FullName),
                new SqlParameter("@Address",memberEntity.Address),
                new SqlParameter("@SalutationId",memberEntity.SalutationId),
                new SqlParameter("@MemberId",memberEntity.MemberId),
                new SqlParameter("@RentedId",memberEntity.RentedId),

            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }

        public int Count(MemberEntity memberEntity)
        {
            strSql = "SELECT COUNT(*) FROM Member WHERE FullName=" + "@FullName";
            SqlParameter[] sqlPara =
           {
                 new SqlParameter("@FullName",memberEntity.FullName),
            };

            int sucess = Convert.ToInt32(connection.ExecuteScalar(CommandType.Text, strSql, sqlPara));

            return sucess;
        }

        public DataTable GetSalutation()
        {
            strSql = "select * from Salutation";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable GetRented()
        {
            strSql = "select * from Rent";

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
