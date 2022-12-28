
namespace Assignment2.Entities.Salutation
{
    public class SalutationEntity
    {
        public int SalutationId { get; set; }

        public string Salutation { get; set; }


        public SalutationEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.SalutationId = 0;
            this.Salutation = string.Empty;
        }

    }
}
