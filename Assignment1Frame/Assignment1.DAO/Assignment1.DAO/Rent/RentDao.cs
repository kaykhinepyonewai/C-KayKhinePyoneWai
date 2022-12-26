using Assignment1.DAO.Common;
using Assignment1.Entities.Member;
using Assignment1.Entities.Rent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.DAO.Rent
{
    public class RentDao
    {

        private DBConnection connection = new DBConnection();

        private string strSql = String.Empty;

        private DataTable resultDataTable = new DataTable();

        private int existCount;

        public DataTable GetAll()
        {
            //strSql = "select * from ((Member as m INNER JOIN Rent as r ON m.MemberId = r.MemberId) INNER JOIN Salutation as s ON m.SalutationId=s.SalutationId);";
            strSql = "select * From Rent,Member Where Rent.MemberId=Member.MemberId";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }


        public DataTable Get(int id)
        {
            strSql = "select * from Rent,Member WHERE Rent.RentedId=" + id + " and Rent.MemberId=Member.MemberId";
            return connection.ExecuteDataTable(CommandType.Text, strSql);

        }

        public int Count(RentEntity rentEntity)
        {
            strSql = "SELECT COUNT(*) FROM Rent WHERE MovieRented=" + "@MovieRented";
            SqlParameter[] sqlPara =
           {
                 new SqlParameter("@MovieRented",rentEntity.movierented),
            };

            int sucess = Convert.ToInt32(connection.ExecuteScalar(CommandType.Text, strSql, sqlPara));

            return sucess;
        }

        public bool Insert(RentEntity rentEntity)
        {
            
            strSql = "INSERT INTO Rent(MovieRented,MemberId) " + "VALUES (@MovieRented,@MemberId)";
            SqlParameter[] sqlPara =
            {
                new SqlParameter("@MovieRented",rentEntity.movierented),
                new SqlParameter("@MemberId",rentEntity.memberid),

            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }


        public bool Update(RentEntity rentEntity)
        {
            strSql = "UPDATE Rent SET MovieRented=@MovieRented,MemberId=@MemberId WHERE RentedId=@RentedId";
            SqlParameter[] sqlPara =
            {
                 new SqlParameter("@MovieRented",rentEntity.movierented),
                new SqlParameter("@MemberId",rentEntity.memberid),
                new SqlParameter("@RentedId",rentEntity.rentedid),
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }

        public DataTable GetMember()
        {
            strSql = "select * from Member";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Delete(int id)
        {
            strSql = "DELETE FROM Rent WHERE RentedId=@RentedId";

            SqlParameter[] sqlPara =
            {
                new SqlParameter("@RentedId",id)
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }




    }
}
