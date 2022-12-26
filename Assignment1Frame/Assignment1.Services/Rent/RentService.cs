using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DAO.Member;
using Assignment1.DAO.Rent;
using Assignment1.Entities.Member;
using Assignment1.Entities.Rent;

namespace Assignment1.Services.Rent
{
    public class RentService
    {
        RentDao rentDao = new RentDao();

        public DataTable GetAll()
        {
            DataTable dt = rentDao.GetAll();
            return dt;
        }

        public DataTable Get(int id)
        {
            DataTable dt = rentDao.Get(id);
            return dt;
        }

        public int Count(RentEntity rentEntity)
        {
            return rentDao.Count(rentEntity);
        }

        public bool Insert(RentEntity rentEntity)
        {
            return rentDao.Insert(rentEntity);
        }

        public bool Update(RentEntity rentEntity)
        {
            return rentDao.Update(rentEntity);
        }

        public DataTable GetMember()
        {
            DataTable dt = rentDao.GetMember();
            return dt;
        }

        public bool Delete(int id)
        {
            return rentDao.Delete(id);
        }

    }
}
