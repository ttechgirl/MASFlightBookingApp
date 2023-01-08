using MASFlightBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MASFlightBookingApp.Repositories
{
    public interface IFlightRepository: IDisposable
    {
        Task<GetFlights> GetAllFlights(string path);
        Task<BuyFlightsResponse> BuyFlightTickets(BuyFlightsRequest requests);
        Task<CheckFlights> CheckFlightDetails(long BookingId);
        Task<UpdateFlights> UpdateFlightDetails(UpdateFlights requests);
        Task<DeleteFlights> RevokeFlights(long BookingId);
        public void Save();
    }
}
