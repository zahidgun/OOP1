﻿using System;

namespace OPP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStok = 3;


            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitInStok = 5 };

            //PascalCase     //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Uptade(product1);


            //productManager.Topla2(3,6);

            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);

          

            //int, double, bool... Değer tip
            //diziler, class, abstract class, interface... Referans Tip.
            //REf-OUT

            
        }
    }
}
