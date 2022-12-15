using MASFlightBookingApp.Models;
using MASFlightBookingApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;
using System.Text.Encodings.Web;

namespace MASFlightBookingApp.Controllers
{
    public class MASFlightBookingController : Controller
    {
        private IFlightRepository flightRepository;
        public MASFlightBookingController()
        {
            //initialization
            flightRepository = new FlightRepository(new MASFlightDBContext());
        }
        public IActionResult Index()
        {
            var allFlights = from flight in flightRepository.GetAllFlights()
                          select flight;
            return View(allFlights);
        }
        
        public IActionResult CheckFlightDetails(long BookingId)
        {
            var request = flightRepository.CheckFlightDetails(BookingId);
            return View(request);
        }

        public IActionResult BuyFlightTicket()
        {
            return View(new BuyFlightsRequest());
        }
        [HttpPost]
        public IActionResult BuyFlightTicket(BuyFlightsRequest buyFlights)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    flightRepository.BuyFlightTickets(buyFlights);
                    flightRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch(DataException)
            {
                ModelState.AddModelError("", "Unable to book flight. Try again and if the problem persists check details inputed");
            }
            return View(buyFlights);
        }

        public IActionResult UpdateFlightDetails(long BookingId)
        {
            var request = flightRepository.CheckFlightDetails(BookingId);
            return View(request);
        }
        [HttpPost]
        public IActionResult UpdateFlightDetails(UpdateFlights updateFlights)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    flightRepository.UpdateFlightDetails(updateFlights);
                    flightRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch(DataException)
            {
                ModelState.AddModelError("","");

            }
            return View(updateFlights);
        }

        public IActionResult DeleteFlight(long BookingId,bool? saveChanges)
        {
            if (saveChanges.GetValueOrDefault()) 
            {
                ViewBag.ErrorMessage = "Unable to save changes.Try again";

            }
            CheckFlights flights = flightRepository.CheckFlightDetails(BookingId);
            return View(flights);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(long BookingId)
        {
            try
            {
                CheckFlights flights = flightRepository.CheckFlightDetails(BookingId);
                flightRepository.RevokeFlights(BookingId);
                flightRepository.Save();
            }
        }

        public IActionResult WelcomeNote()
        {
            return View();
        }
    
        public IActionResult Register()
        {
            return View();
        }
      
        public IActionResult Login()
        {
            return View();
        }






    }
}
