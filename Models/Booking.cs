namespace SoftInn.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Room RoomId { get; set; }
    }
}
