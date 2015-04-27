using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using T2OnlineShop.Models;

namespace T2OnlineShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}