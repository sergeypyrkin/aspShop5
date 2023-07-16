﻿using Microsoft.AspNetCore.Mvc;

using ShopAspNet5.Interfaces;
using ShopAspNet5.Models;
using ShopAspNet5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAspNet5.Controllers {
    public class ShopCartController : Controller {

        private IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart) {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index() {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel {
                shopCart = _shopCart
            };

            return View(obj);

        }

        public RedirectToActionResult addToCart(int id) {
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id);
            if(item != null) {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

    }
}
