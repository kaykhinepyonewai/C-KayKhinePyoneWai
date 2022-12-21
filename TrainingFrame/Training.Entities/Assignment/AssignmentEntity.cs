using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Entities.Assignment
{
    public class AssignmentEntity
    {
        
        public int assignmentid { get; set; }

        public string studentname { get; set; }

        public string teachername { get; set; }

        public string assignmentname { get; set; }

        public string classname { get; set; }

        public string remark { get; set; }

        public DateTime finisheddate { get; set; }

        public AssignmentEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
           
            this.assignmentid = 0;
            this.studentname = string.Empty;
            this.teachername = string.Empty;
            this.assignmentname = string.Empty;
            this.classname = string.Empty;
            this.remark = string.Empty;
            this.finisheddate = DateTime.Now;

        }



    }
}
