using MASFlightBookingApp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MASFlightBookingApp.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private MASFlightDBContext dbContext;
        public FlightRepository(MASFlightDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<BuyFlightsResponse> BuyFlightTickets(BuyFlightsRequest requests)
        {

            BuyFlightsResponse deserialize;

            var url = $"{configuration.GetValue<string>("API:url")}/Buy_Flight_Ticket";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization",$"Bearer")

        }

        public Task<CheckFlights> CheckFlightDetails(long BookingId)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public List<GetFlights> GetAllFlights()
        {
            throw new System.NotImplementedException();
        }

        public Task<DeleteFlights> RevokeFlights(long BookingId)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public Task<UpdateFlights> UpdateFlightDetails(UpdateFlights requests)
        {
            throw new System.NotImplementedException();
        }
    }
}
