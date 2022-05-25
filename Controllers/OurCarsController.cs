using Microsoft.AspNetCore.Mvc;
using RideSharingApplication.Data;
using RideSharingApplication.Models;
using RideSharingApplication.Services.Interfaces;

namespace RideSharingApplication.Controllers
{
    public class OurCarsController : Controller
    {

        private readonly ICarService carService;

        public OurCarsController(ICarService _carService)
        {
            carService = _carService;
        }

    
        public IActionResult Index()
        {
            IEnumerable<Car> obCarList = carService.getAllCars();
            return View(obCarList);
        }
    }
}
