using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Entities.Rent
{
    public class RentEntity
    {

        public int rentedid { get; set; }

        public string movierented { get; set; }

        public int memberid { get; set; }


        public RentEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.rentedid = 0;
            this.movierented = string.Empty;
            this.memberid = 0;
        }
    }
}
