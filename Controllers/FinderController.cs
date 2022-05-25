using AspNetCoreServicesApp.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RideSharingApplication.Models;

namespace RideSharingApplication.Controllers
{
    public class FinderController : Controller
    {

        private readonly ITripService tripService;

        public FinderController(ITripService _tripService)
        {
            this.tripService = _tripService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Trip obj)
        {

            tripService.AddTrip(obj);

            return RedirectToAction("Index");
        }

    }
}
