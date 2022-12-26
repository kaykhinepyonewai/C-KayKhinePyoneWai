using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Entities.Salutation
{
    public class SalutationEntity
    {
        public int salutationid { get; set; }

        public string salutation { get; set; }


        public SalutationEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.salutationid = 0;
            this.salutation = string.Empty;
        }

    }
}
