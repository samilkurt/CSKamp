﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 3;
            product1.ProductName = "Telefon";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 12;

            Product product2 = new Product { Id = 2, CategoryId = 4, ProductName = 
                "Tablet", UnitPrice = 400, UnitsInStock = 24 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            
        }
    }
}
