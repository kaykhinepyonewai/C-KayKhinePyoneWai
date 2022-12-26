using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DAO.Salutation;
using Assignment1.Entities.Salutation;

namespace Assignment1.Services.Salutation
{
    public class SalutaionService
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


        public bool Delete(int id)
        {
            return salutationDao.Delete(id);
        }

    }
}
