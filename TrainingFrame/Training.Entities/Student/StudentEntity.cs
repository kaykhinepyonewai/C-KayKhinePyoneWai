using System;

namespace Training.Entities.Student
{
    public class StudentEntity

    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string CourseName { get; set; }

        public decimal CourseFee { get; set; }

        public DateTime JoningDate { get; set; }

        public StudentEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.StudentId = 0;
            this.Name = String.Empty;
            this.Address = String.Empty;
            this.CourseName = String.Empty;
            this.CourseFee = 0;
            this.JoningDate = DateTime.Now;
        }
    }
}
