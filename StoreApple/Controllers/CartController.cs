using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreApple.Helper;
using StoreApple.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using StoreApple.Data;
using StoreApple.Models.Domain;
using AutoMapper;


namespace StoreApple.Controllers
{
    public class CartController : Controller
    {
        //private readonly ProductData productData;
        //public CartController(ProductData productData)
        //{
        //    this.productData = productData;
        //}
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.ProductModel.ProductPrice * item.Quantity);
            return View();
        }

        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {
            
            if (SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart") == null)
            {
                List<ProductToCart> cart = new List<ProductToCart>();
                cart.Add(new ProductToCart { ProductModel = productData.ProductList.FirstOrDefault(p => p.ProductId == id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new ProductToCart { ProductModel = productData.ProductList.FirstOrDefault(p => p.ProductId == id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int isExist(int id)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].ProductModel.ProductId == id)
                {
                    return i;
                }
            }
            return -1;
        }


        ProductData productData;
        DataContext dataContext;
        IMapper mapper;
        public CartController(ProductData productData, DataContext dataContext, IMapper mapper)
        {
            this.productData = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult checkout()
        {
            ProductModel productModel = new ProductModel();
            return View(productModel);
        }
        [HttpPost]
        public IActionResult checkout(ProductModel productModel)
        {
            if (!ModelState.IsValid)
            {
                ProductModel newProduct = new ProductModel();

                newProduct.Ten = productModel.Ten;
                newProduct.Email = productModel.Email;
                newProduct.SDT = productModel.SDT;
                newProduct.Feedback = productModel.Feedback;
                newProduct.CreateDate = DateTime.Now;
                Checkout p = new Checkout()
                {
                    Ten = newProduct.Ten,
                    Email = newProduct.Email,
                    SDT = newProduct.SDT,
                    Feedback = newProduct.Feedback,
                    
                    CreateDate = newProduct.CreateDate
                   
                };
                dataContext.Checkouts.Add(p);
                dataContext.SaveChanges();



                return RedirectToAction("Index", "Cart");
            }
            else
            {
                return View(productModel);
            }

        }

        [HttpGet]
        public IActionResult product()
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

        public IActionResult check ()
        {
            return View();
        }
        

    }
}