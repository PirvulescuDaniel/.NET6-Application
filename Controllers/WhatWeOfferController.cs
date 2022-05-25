using Microsoft.AspNetCore.Mvc;

namespace RideSharingApplication.Controllers
{
    public class WhatWeOfferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
