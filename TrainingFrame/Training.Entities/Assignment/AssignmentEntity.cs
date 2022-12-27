using System;

namespace Training.Entities.Assignment
{
    public class AssignmentEntity
    {
        
        public int AssignmentId { get; set; }

        public string StudentName { get; set; }

        public string TeacherName { get; set; }

        public string AssignmentName { get; set; }

        public string ClassName { get; set; }

        public string Remark { get; set; }

        public DateTime FinishedDate { get; set; }

        public AssignmentEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
           
            this.AssignmentId = 0;
            this.StudentName = string.Empty;
            this.TeacherName = string.Empty;
            this.AssignmentName = string.Empty;
            this.ClassName = string.Empty;
            this.Remark = string.Empty;
            this.FinishedDate = DateTime.Now;

        }



    }
}
