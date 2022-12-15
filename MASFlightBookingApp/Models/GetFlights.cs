namespace MASFlightBookingApp.Models
{
    public class GetFlights
    {
        public int Number_of_passanger { get; set; }
        public Airline airline { get; set; }
        public Departure departure { get; set; }
        public Destination destination { get; set; }
        public FlightCategories flightCategories { get; set; }
        public TravelerAge travelerAge { get; set; }
        public Trip_Type Trip_Type { get; set; }
        public decimal amount { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
