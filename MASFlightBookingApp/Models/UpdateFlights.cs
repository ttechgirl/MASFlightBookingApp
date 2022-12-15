using System;

namespace MASFlightBookingApp.Models
{
    public class UpdateFlights
    {
        public long BookingId { get; set; }
        public string TicketName { get; set; }
        public int Number_of_passanger { get; set; }
        public Airline airline { get; set; }
        public Departure departure { get; set; }
        public Destination destination { get; set; }
        public DateTime dateTime { get;} = DateTime.Now;
        public FlightCategories flightCategories { get; set; }
        public TravelerAge travelerAge { get; set; }
        public Trip_Type Trip_Type { get; set; }

    }
}
