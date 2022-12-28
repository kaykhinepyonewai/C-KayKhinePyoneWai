using Assignment.DAO.Member;
using Assignment2.Entities.Member;
using System.Data;


namespace Assignment2.Services.Member
{
    public class MemberService
    {
        private MemberDao memberDao = new MemberDao();
        public DataTable GetAll()
        {
            DataTable dt = memberDao.GetAll();
            return dt;
        }

        public DataTable GetAllExport()
        {
            DataTable dt = memberDao.GetAllExport();
            return dt;
        }

        public bool Insert(MemberEntity memberEntity)
        {
            return memberDao.Insert(memberEntity);
        }

        public int TakeSalutationId(string salutaionName)
        {
            return memberDao.TakeSalutationId(salutaionName);
        }

        public int TakeRentedId(string MovieRented)
        {
            return memberDao.TakeRentedId(MovieRented);
        }

        public DataTable Get(int id)
        {
            DataTable dt = memberDao.Get(id);
            return dt;
        }

        public int Count(MemberEntity memberEntity)
        {
            return memberDao.Count(memberEntity);
        }

        public bool Update(MemberEntity memberEntity)
        {
            return memberDao.Update(memberEntity);
        }

        public DataTable GetSalutation()
        {
            DataTable dt = memberDao.GetSalutation();
            return dt;
        }

        public DataTable GetRented()
        {
            DataTable dt = memberDao.GetRented();
            return dt;
        }

        public bool Delete(int id)
        {
            return memberDao.Delete(id);
        }

    }
}
