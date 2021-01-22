using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApple.Models;
using Microsoft.AspNetCore.Mvc;

namespace StoreApple.Controllers
{
    public class DetailController : Controller
    {
        private readonly ProductData productData;
        public DetailController(ProductData productData)
        {
            this.productData = productData;
        }
        [HttpGet("Detail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            ProductModel productModel = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
            return View(productModel);
        }

       
    }
}