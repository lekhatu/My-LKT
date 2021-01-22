using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreApple.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using StoreApple.Models.Domain;
using StoreApple.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace StoreApple.Controllers
{
    public class HomeController : Controller
    {
        private ProductData data;

        DataContext dataContext;
        ProductData productData;
        IMapper mapper;
        

        public HomeController(ProductData productData, DataContext dataContext, IMapper mapper)
        {
            data = productData;

            this.productData = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
       

        [HttpGet]
        public IActionResult Index()
        {
            

            List<ProductModel> products = new List<ProductModel>();
            List<Product> productss = dataContext.Products.ToList();
            foreach (var item in productss)
            {

                ProductModel p = new ProductModel()
                {
                    ProductId = item.ProductId,
                    ProductImage = item.ProductImage,
                    ProductName = item.ProductName,
                    ProductQuantity = item.ProductQuantity,
                    ProductPrice = item.ProductPrice,
                    CreateDate = item.CreateDate,
                    //CategoryId = 1
                    CategoryId = item.CategoryId
                };
                products.Add(p);
            }
            

            return View(products);
        }


        
        public IActionResult blog1()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            ProductModel productModel = new ProductModel();
            return View(productModel);
        }
        [HttpPost]
        public IActionResult Contact(ProductModel productModel)
        {
            if (!ModelState.IsValid)
            {
                ProductModel newProduct = new ProductModel();

                newProduct.Ten = productModel.Ten;
                newProduct.Email = productModel.Email;
                newProduct.SDT = productModel.SDT;
                newProduct.Feedback = productModel.Feedback;
                newProduct.CreateDate = DateTime.Now;
                Contact p = new Contact ()
                {
                    Ten = newProduct.Ten,
                    Email = newProduct.Email,
                    SDT = newProduct.SDT,
                    Feedback = newProduct.Feedback,

                    CreateDate = newProduct.CreateDate

                };
                dataContext.Contacts.Add(p);
                dataContext.SaveChanges();



                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(productModel);
            }

        }
       



    }
}



