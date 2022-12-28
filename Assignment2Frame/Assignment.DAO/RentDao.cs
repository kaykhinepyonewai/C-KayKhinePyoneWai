using Assignment2.Entities.Rent;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.DAO.Common;

namespace Assignment.DAO
{
    public class RentDao
    {
        private DBConnection connection = new DBConnection();

        private string strSql = String.Empty;

        public DataTable GetAll()
        {
            strSql = "select * from Rent";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable Get(int id)
        {
            strSql = "select * from Rent WHERE Rent.RentedId=" + id;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public int Count(RentEntity rentEntity)
        {
            strSql = "SELECT COUNT(*) FROM Rent WHERE MovieRented=" + "@MovieRented";
            SqlParameter[] sqlPara =
           {
                 new SqlParameter("@MovieRented",rentEntity.MovieRented),
            };

            int sucess = Convert.ToInt32(connection.ExecuteScalar(CommandType.Text, strSql, sqlPara));

            return sucess;
        }

        public int CountUpdate(RentEntity rentEntity)
        {
            strSql = "SELECT COUNT(*) FROM Rent WHERE MovieRented=" + "@MovieRented and RentedId!=" + "@RentedId";
            SqlParameter[] sqlPara =
           {
                 new SqlParameter("@MovieRented",rentEntity.MovieRented),
                 new SqlParameter("@RentedId",rentEntity.RentedId),
            };

            int sucess = Convert.ToInt32(connection.ExecuteScalar(CommandType.Text, strSql, sqlPara));
            return sucess;
        }

        public bool Insert(RentEntity rentEntity)
        {

            strSql = "INSERT INTO Rent(MovieRented) " + "VALUES (@MovieRented)";
            SqlParameter[] sqlPara =
            {
                new SqlParameter("@MovieRented",rentEntity.MovieRented),

            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }


        public bool Update(RentEntity rentEntity)
        {

            strSql = "UPDATE Rent SET MovieRented=@MovieRented WHERE RentedId=@RentedId";
            SqlParameter[] sqlPara =
            {
                 new SqlParameter("@MovieRented",rentEntity.MovieRented),
                new SqlParameter("@RentedId",rentEntity.RentedId),
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
