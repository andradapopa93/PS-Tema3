using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace T2OnlineShop.Models
{
    [Bind(Exclude = "ProductId")]

    public class Product
    {

        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [DisplayName("Product")]
        [Required(ErrorMessage = "The product name is required")]
        [StringLength(160)]
        public string name { get; set; }

        [DisplayName("Product type")]
        [Required(ErrorMessage = "The product type is required")]
        [StringLength(160)]
        public string type { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 100.00,
            ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal price { get; set; }

    }
}