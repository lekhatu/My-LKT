using AutoMapper;
using StoreApple.Models;
using StoreApple.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApple.Helper
{
    public class ModelHelper : Profile
    {
        public ModelHelper()
        {
            CreateMap<Product, ProductModel>();
        }
    }
}
