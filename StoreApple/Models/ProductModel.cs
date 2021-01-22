using StoreApple.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApple.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Not null")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string ProductName { get; set; }

        [Required]
        [Range(0, 100)]
        [DisplayName("Quantity")]
        public int ProductQuantity { get; set; }

        [DisplayName("Image")]
        public string ProductImage { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [Required]
        [Range(0, 999.99)]
        [DisplayName("Price")]
        public double ProductPrice { get; set; }
        [DisplayName("Create on")]
        public DateTime CreateDate { get; set; }
        public string Descriptions { get; set; }
        private static int nextId = 1;

        [DisplayName("Ten")]
        [Required(ErrorMessage = "Not null")]
        public string Ten { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Not null")]
        public string Email { get; set; }

        [DisplayName("SDT")]
        [Required(ErrorMessage = "Not null")]
        public string SDT { get; set; }
        [DisplayName("Feedback")]
        public string Feedback { get; set; }



        public Category Category { get; set; }
        public string CategoryName { get; set; }

       

        public ProductModel()
        {
            ProductId = nextId;
            nextId++;
        }

        public override int GetHashCode()
        {
            return ProductId;
        }
    }
}
