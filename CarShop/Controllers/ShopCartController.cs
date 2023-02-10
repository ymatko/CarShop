﻿using Microsoft.AspNetCore.Mvc;
using CarShop.Data.Models;
using CarShop.ViewModels;
using CarShop.Data.Interfaces;

namespace CarShop.Controllers
{
	public class ShopCartController : Controller
	{
		private readonly IAllCars _carRep;
		private readonly ShopCart _shopCart;

		public ShopCartController(IAllCars carRep, ShopCart shopCart)
		{
			_carRep = carRep;
			_shopCart = shopCart;
		}

		public ViewResult Index()
		{
			var items = _shopCart.GetShopItems();
			_shopCart.listShopItems = items;

			var obj = new ShopCartViewModel
			{
				shopCart = _shopCart,
			};

			return View(obj);
		}

		public RedirectToActionResult addToCart(int id)
		{
			var item = _carRep.Cars.FirstOrDefault(i => i.id == id);
			if (item != null)
			{
				_shopCart.AddToCart(item);
			}
			return RedirectToAction("Index");
		}
	}
}
