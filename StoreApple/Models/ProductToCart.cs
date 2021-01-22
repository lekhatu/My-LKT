using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApple.Models
{
    public class ProductToCart
    {
        public ProductModel ProductModel { get; set; }
        public int Quantity { get; set; }
    }

   
}
