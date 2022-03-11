using System;
using Class_and__Inheritance.Models;

namespace Class_and__Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.productName = "Nusretin et kitabi";
            book.authorName = "CZN burak";
            book.pageCount = 331;
            book.discountPercent = 12;
            book.costPrice = 31;
            book.salePrice = 68;
            book.saledPrice = 37;
            book.getInfo();
            Console.WriteLine($"Endirim Faizi:   {book.GetDiscountedPrice()}");
        }
    }
}