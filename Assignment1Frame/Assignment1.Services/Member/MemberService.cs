using Assignment1.DAO.Salutation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Entities.Member;
using Assignment1.DAO.Member;
using Assignment1.Entities.Salutation;

namespace Assignment1.Services.Member
{
    public class MemberService
    {
        private MemberDao memberDao = new MemberDao();
        public DataTable GetAll()
        {
            DataTable dt = memberDao.GetAll();
            return dt;
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

        public bool Insert(MemberEntity memberEntity)
        {
            return memberDao.Insert(memberEntity);
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

        public bool Delete(int id)
        {
            return memberDao.Delete(id);
        }

    }
}
