
namespace Assignment2.Entities.Rent
{
    public class RentEntity
    {
        public int RentedId { get; set; }

        public string MovieRented { get; set; }


        public RentEntity()
        {
            InitializedObjectValue();
        }

        internal void InitializedObjectValue()
        {
            this.RentedId = 0;
            this.MovieRented = string.Empty;
        }

    }
}
