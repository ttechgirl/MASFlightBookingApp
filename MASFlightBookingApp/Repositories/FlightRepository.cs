using MASFlightBookingApp.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MASFlightBookingApp.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly IConfiguration configuration;
        public FlightRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<GetFlights> GetAllFlights()
        {

            throw new System.NotImplementedException();


        }
        public async Task<BuyFlightsResponse> BuyFlightTickets(BuyFlightsRequest requests)
        {

             BuyFlightsResponse deserialize;

            var url = $"{configuration.GetValue<string>("API:url")}/";

            var client = new HttpClient();
            //client.BaseAddress = new Uri();
             client.DefaultRequestHeaders.Clear();


            //serialize http response to json string
            var data = JsonConvert.SerializeObject(requests);
            var sendRequest = await client.PostAsync(url, new StringContent(data, Encoding.UTF8,"application/json"));
            var response = await sendRequest.Content.ReadAsStringAsync(); 

            //deserialise json to specified  .net type
            deserialize = JsonConvert.DeserializeObject<BuyFlightsResponse>(response);
            return deserialize;

        }

        public async Task<CheckFlights> CheckFlightDetails(long BookingId)
        {
            CheckFlights deserialize;

            var url = $"{configuration.GetValue<string>("API:url")}/";
            var client = new HttpClient();

            var sendRequest = await client.GetAsync(url);
            var response = await sendRequest.Content.ReadAsStringAsync();

            deserialize = JsonConvert.DeserializeObject<CheckFlights>(response);

            return deserialize;


        }

        public Task<UpdateFlights> UpdateFlightDetails(UpdateFlights requests)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
                  throw new System.NotImplementedException();
        }

        public Task<DeleteFlights> RevokeFlights(long BookingId)
        {
            throw new System.NotImplementedException();
        }



        public void Save()
        {
        }

              


    }

}




