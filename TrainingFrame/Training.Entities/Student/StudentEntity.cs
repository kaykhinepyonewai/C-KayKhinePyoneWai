using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Entities.Student
{
    public class StudentEntity

    {
        public int studentid { get; set; }
        public string name { get; set; }

        public string address { get; set; }

        public string coursename { get; set; }

        public decimal coursefee { get; set; }

        public DateTime joningdate { get; set; }

        public StudentEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.studentid = 0;
            this.name = String.Empty;
            this.address = String.Empty;
            this.coursename = String.Empty;
            this.coursefee = 0;
            this.joningdate = DateTime.Now;
        }
    }
}
