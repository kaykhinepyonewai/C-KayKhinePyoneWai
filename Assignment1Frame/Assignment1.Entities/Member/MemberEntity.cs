using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Entities.Member
{
    public class MemberEntity
    {
      
        public int memberid { get; set; }

        public string fullname { get; set;}

        public string address { get; set; }

        public int salutationid { get; set; }

        public MemberEntity()
        {
            InitializedObjectValue();
        }
       
        internal void InitializedObjectValue()
        {
            this.memberid = 0;
            this.fullname = string.Empty;
            this.address = string.Empty;
            this.salutationid = 0;
         
        }

    }
}
