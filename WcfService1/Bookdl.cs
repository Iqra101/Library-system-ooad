using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Bookdl
    {
        public static List<Book> Library = new List<Book>();
        public static List<Book> Market = new List<Book>();
        public static void AddBookToLib(Book b)
        {
            
        }
        public static void AddBookToMar(Book b)
        {

        }
        public static void UpdatePrice(Book b)
        {

        }
        public static void UpdateQuantity(Book b)
        {

        }
        public static void DeleteBookFromLib(string name, string Location)
        {

        }
        public static void DeleteBookFromMar(Book b)
        {

        }
        public static List<Book> SearchBookFromLibrary(string name)
        {
            return null;
        }
        public static List<Book> SearchBookFromMar(string name)
        {
            return null;
        }
    }
}