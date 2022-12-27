using System.Data;
using Training.DAO.Assignment;
using Training.Entities.Assignment;

namespace Training.Services.Assignment
{
    public class AssignmentService
    {
        private AssignmentDao assignmentDao = new AssignmentDao();


        public DataTable GetAll()
        {
            DataTable dt = assignmentDao.GetAll();
            return dt;
        }

        public DataTable Get(int id)
        {
            DataTable dt = assignmentDao.Get(id);
            return dt;
        }

        public bool Insert(AssignmentEntity assignmentEntity)
        {
            return assignmentDao.Insert(assignmentEntity);
        }

        public bool Update(AssignmentEntity assignmentEntity)
        {
            return assignmentDao.Update(assignmentEntity);
        }

        public bool Delete(int id)
        {
            return assignmentDao.Delete(id);
        }



    }
}
