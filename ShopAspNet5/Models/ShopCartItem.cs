﻿using ShopAspNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAspNet5.Modelss
{
    public class ShopCartItem {

        public int id { get; set; }
        public Car car { get; set; }
        public int price { get; set; }

        public string ShopCartId { get; set; }

    }
}
