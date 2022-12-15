using System;

namespace MASFlightBookingApp.Models
{
    public class BuyFlightsRequest
    {
        public string TicketName { get; set; }
        public int Number_of_passanger { get; set; }
        public Destination destination { get; set; }
        public Departure departure { get; set; }
        public Trip_Type Trip_Type { get; set; }
        public FlightCategories flightCategories { get; set; }
        public TravelerAge travelerAge { get; set; }
        public Airline airline { get; set; }
        public DateTime dateTime { get; } = DateTime.Now;

    }
}
