using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DAO.Student;
using Training.Entities.Student;


namespace Training.Services.Student
{
    public class StudentService
    {
        private StudentDao studentDao = new StudentDao();

        public DataTable GetAll()
        {
            DataTable dt = studentDao.GetAll();
            return dt;
        }

        public bool Insert(StudentEntity studentEntity)
        {
            return studentDao.Insert(studentEntity);
        }

        public bool Update(StudentEntity studentEntity)
        {
            return studentDao.Update(studentEntity);
        }

        public DataTable Get(int id)
        {
            DataTable dt = studentDao.Get(id);
            return dt;
        }

        public bool Delete(int id)
        {
            return studentDao.Delete(id);
        }

    }
}
