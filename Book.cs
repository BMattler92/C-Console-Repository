using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace BookExceptionDemo
{
    class BookException : Exception
    {
        private static string msg = "  The price of this book is invalid";

        public BookException(string theTitle, double thePrice, int thePages)
            : base(msg)
        {
            WriteLine("  The book {0} costs {1} for {2} pages, which is invalid.", theTitle, thePrice.ToString("C2"), thePages);
        }
    }

    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public double price { get; set; }
        public int pages { get; set; }

        public Book(string Title, string Author, double Price, int Pages)
        {
            title = Title;
            author = Author;
            price = Price;
            pages = Pages;
        }
    }
}