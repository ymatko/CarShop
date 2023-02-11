﻿using CarShop.Data.Interfaces;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
	public class HomeController : Controller
	{
        private readonly IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public  ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }
    }
}
