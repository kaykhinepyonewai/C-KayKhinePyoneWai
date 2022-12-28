using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Entities.Member
{
    public class MemberEntity
    {
        public int MemberId { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public int SalutationId { get; set; }

        public int RentedId { get; set; }

        public MemberEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.MemberId = 0;
            this.FullName = string.Empty;
            this.Address = string.Empty;
            this.SalutationId = 0;
            this.RentedId = 0;

        }

    }
}
