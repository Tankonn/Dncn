namespace Dacn.Models
{
    public class BookingModel
    {
        public string Destination { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime LeavingDate { get; set; }
    }

}
