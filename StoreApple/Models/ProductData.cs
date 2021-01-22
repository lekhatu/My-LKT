using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApple.Models
{
    public class ProductData
    {
        public List<ProductModel> ProductList { get; set; }
        public static ProductData initData()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.AddRange(new List<ProductModel>
            {
                new ProductModel()
                {
                    ProductName = "iphoneX",
                    ProductImage = "iphoneX.png",
                    Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now,

                    Ten = "Nguyen Van A",
                    Email = "sfsdfg@gmail.com",
                    SDT = "0123456789",
                    Feedback ="abc",

                    CategoryName ="Huawei",
                },
                 new ProductModel()
                {
                    ProductName = "iphoneX",
                    ProductImage = "iphoneX.png",
                       Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                   CreateDate = DateTime.Now,

                  Ten = "Nguyen Van A",
                    Email = "sfsdfg@gmail.com",
                    SDT = "0123456789",
                    Feedback ="abc",

                    CategoryName ="Huawei",
                },
                 new ProductModel()
                {
                    ProductName = "iphoneX",
                    ProductImage = "iphoneX.png",
                       Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                   CreateDate = DateTime.Now,

                   Ten = "Nguyen Van A",
                    Email = "sfsdfg@gmail.com",
                    SDT = "0123456789",
                    Feedback ="abc",

                    CategoryName ="Huawei",
                },
                 new ProductModel()
                {
                    ProductName = "iphoneX",
                    ProductImage = "iphoneX.png",
                       Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now,

                    Ten = "Nguyen Van A",
                    Email = "sfsdfg@gmail.com",
                    SDT = "0123456789",
                    Feedback ="abc",

                    CategoryName ="Huawei",
                },





            }); ;

            return new ProductData()
            {
                ProductList = products
            };
        }
    }
}
