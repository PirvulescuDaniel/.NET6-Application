using AspNetCoreServicesApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RideSharingApplication.Models;
using RideSharingApplication.Repositories.Interfaces;

namespace RideSharingApplication.Controllers
{
    public class FindResultController : Controller
    {
        private readonly ITripService tripService;

        public FindResultController(ITripService _tripService)
        {
            this.tripService = _tripService;
        }

        [HttpGet]
        public IActionResult Index(string tripName)
        {
            IEnumerable<Trip> trips = tripService.GetAllTrips();

            return View(trips);
        }

        [HttpPost]
        public IActionResult FindByName(string tripName)
        {
            IEnumerable<Trip> trips = tripService.GetTripsByName(tripName);

            return View(trips);
        }
    }
}
