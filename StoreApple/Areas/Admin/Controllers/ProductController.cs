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
    [Authorize(Roles = "Administrator")]
    [Area("Admin")]
    public class ProductController : Controller
    {
        DataContext dataContext;
        ProductData productData;
        IMapper mapper;
        public ProductController(ProductData productData, DataContext dataContext, IMapper mapper)
        {
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
                //products.Add(mapper.Map<ProductModel>(item));

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
        [HttpGet]
        public IActionResult Add()
        {
            
            ViewBag.CategoryId = new SelectList(dataContext.Categories, "CategoryId", "CategoryName");
            ProductModel productModel = new ProductModel();
            return View(productModel);
        }
        [HttpPost]
        public IActionResult Add(ProductModel productModel, IFormFile photo)
        {
            if (!ModelState.IsValid)
            {
                ProductModel newProduct = new ProductModel();
                if (photo == null || photo.Length == 0)
                {
                    newProduct.ProductImage = "abc.png";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    newProduct.ProductImage = photo.FileName;
                }
                newProduct.ProductName = productModel.ProductName;
                newProduct.ProductQuantity = productModel.ProductQuantity;
                newProduct.ProductPrice = productModel.ProductPrice;
                newProduct.CreateDate = DateTime.Now;
                newProduct.CategoryId = productModel.CategoryId;
                //newProduct.CategoryId = productModel.CategoryId;

                productData.ProductList.Add(newProduct);
                Product p = new Product()
                {
                    ProductName = newProduct.ProductName,
                    ProductImage = newProduct.ProductImage,
                    ProductQuantity = newProduct.ProductQuantity,
                    ProductPrice = newProduct.ProductPrice,
                    //CategoryId = 1,
                    CategoryId = newProduct.CategoryId,
                    CreateDate = newProduct.CreateDate

                };
                dataContext.Products.Add(p);
                dataContext.SaveChanges();



                return RedirectToAction("Index", "Product");
            }
            else
            {
                //var item = (from p in dataContext.Categories select p).ToList();
                //ViewBag.Selected = new SelectList(item, "CategoryId", "CategoryName");
                return View(productModel);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // ProductModel oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);

            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            ProductModel oldProduct = new ProductModel()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName
            };

            return View(oldProduct);
        }
        [HttpPost]
        public IActionResult Edit(int id, ProductModel productModel, IFormFile photo)
        {
            if (!ModelState.IsValid)
            {
                //ProductModel oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
                //oldProduct.ProductName = productModel.ProductName;
                //oldProduct.ProductQuantity = productModel.ProductQuantity;
                //oldProduct.ProductPrice = productModel.ProductPrice;
                //oldProduct.CreateDate = DateTime.Now;



                Product p = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
                p.ProductName = productModel.ProductName;


                if (photo == null || photo.Length == 0)
                {
                    p.ProductImage = "abc.png";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    p.ProductImage = photo.FileName;
                }

                p.ProductPrice = productModel.ProductPrice;
                p.ProductQuantity = productModel.ProductQuantity;
                p.CreateDate = DateTime.Now;

                dataContext.SaveChanges();

                ViewBag.Status = 1;
            }



            return View(productModel);
        }


        public IActionResult Delete(int id)
        {
            //ProductModel oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            ProductModel oldProduct = new ProductModel()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName
            };
            return View(oldProduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // productData.ProductList.RemoveAll(p => p.ProductId == id);
            Product product = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
            dataContext.Products.Remove(product);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "Product");
        }



        public IActionResult contact()
        {

            return View();
        }
        public IActionResult login()
        {

            return View();
        }
    }
}