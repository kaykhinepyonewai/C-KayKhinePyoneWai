using Assignment.DAO.Salutation;
using Assignment2.Entities.Salutation;
using System.Data;

namespace Assignment2.Services.Salutation
{
    public class SalutationService
    {
        private SalutationDao salutationDao = new SalutationDao();


        public DataTable GetAll()
        {
            DataTable dt = salutationDao.GetAll();
            return dt;
        }

        public DataTable Get(int id)
        {
            DataTable dt = salutationDao.Get(id);
            return dt;
        }

        public bool Insert(SalutationEntity salutationEntity)
        {
            return salutationDao.Insert(salutationEntity);
        }

        public bool Update(SalutationEntity salutationEntity)
        {
            return salutationDao.Update(salutationEntity);
        }

        public int Count(SalutationEntity salutationEntity)
        {
            return salutationDao.Count(salutationEntity);
        }

        public int CountUpdate(SalutationEntity salutationEntity)
        {
            return salutationDao.CountUpdate(salutationEntity);
        }


        public bool Delete(int id)
        {
            return salutationDao.Delete(id);
        }


    }
}
