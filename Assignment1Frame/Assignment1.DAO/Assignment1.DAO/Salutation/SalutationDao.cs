using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Entities.Salutation;
using Assignment1.DAO.Common;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Assignment1.DAO.Salutation
{
    public class SalutationDao
    {
        private DBConnection connection = new DBConnection();

        private string strSql = String.Empty;

        private DataTable resultDataTable = new DataTable();

        private int existCount;


        public DataTable GetAll()
        {
            strSql = "SELECT * FROM Salutation ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM Salutation WHERE SalutationId=" +id;
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public bool Insert(SalutationEntity salutationEntity)
        {
            strSql = "INSERT INTO Salutation(Salutation) " +  "VALUES (@Salutation)";
            SqlParameter[] sqlPara =
            {
                new SqlParameter("@Salutation",salutationEntity.salutation)
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }

        public bool Update(SalutationEntity salutationEntity)
        {
            strSql = "UPDATE Salutation SET Salutation=@Salutation WHERE SalutationId=@SalutationId";
            SqlParameter[] sqlPara =
            {
                 new SqlParameter("@Salutation",salutationEntity.salutation),
                new SqlParameter("@SalutationId",salutationEntity.salutationid),
               
            };

            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
            return success;
        }

        public int Count(SalutationEntity salutationEntity)
        {
            strSql = "SELECT COUNT(*) FROM Salutation WHERE Salutation=" + "@Salutation";
            SqlParameter[] sqlPara =
           {
                 new SqlParameter("@Salutation",salutationEntity.salutation),
            };

            int sucess = Convert.ToInt32 (connection.ExecuteScalar(CommandType.Text, strSql, sqlPara)) ;
            
            return sucess;
        }


        public bool Delete(int id)
        {
            strSql = "DELETE FROM Salutation WHERE SalutationId=@SalutationId";

            SqlParameter[] sqlPara =
            {
                new SqlParameter("@SalutationId",id)
            };

        bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlPara);
        return  success;
        }

}
    }

