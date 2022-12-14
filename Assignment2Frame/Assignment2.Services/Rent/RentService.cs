using Assignment.DAO;
using Assignment2.Entities.Rent;
using System.Data;

namespace Assignment2.Services.Rent
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
        public int CountUpdate(RentEntity rentEntity)
        {
            return rentDao.CountUpdate(rentEntity);
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
