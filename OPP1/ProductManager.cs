using System;
using System.Collections.Generic;
using System.Text;

namespace OPP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {

            Console.WriteLine(product.ProductName + " Eklendi. ");

        }
        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi. ");
        }

        // Ek işlem Yapabilmek için Return Kullanırız.
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
       
        //// Emir Kipi, Git Yap Bitir...
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}

    }
}
