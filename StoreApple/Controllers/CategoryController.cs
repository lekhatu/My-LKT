using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using StoreApple.Models;
using StoreApple.Models.Domain;
using StoreApple.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreApple.Controllers
{
    public class CategoryController : Controller
    {
        ProductData productData;
        DataContext dataContext;
        IMapper mapper;
        public CategoryController(ProductData productData, DataContext dataContext, IMapper mapper)
        {
            this.productData = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            ProductModel productModel = new ProductModel();
            return View(productModel);
        }
        [HttpPost]
        public IActionResult AddCategory(ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                ProductModel newProduct = new ProductModel();

                newProduct.CategoryName = productModel.CategoryName;
               
                
                //newProduct.CategoryId = productModel.CategoryId;
                // productData.ProductList.Add(newProduct);
                Category p = new Category()
                {
                    CategoryName = newProduct.CategoryName,
                   

                };
                dataContext.Categories.Add(p);
                dataContext.SaveChanges();



                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View(productModel);
            }


        }
    }
}