﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetShop.Models;
namespace InternetShop.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
