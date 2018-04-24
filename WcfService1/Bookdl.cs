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
            Library.Add(b);
            
        }
        public static void AddBookToMar(Book b)
        {

        }
        public static void UpdatePrice(Book b)
        {

        }
        public static bool UpdateQuantity(Book b)
        {
            return false;
        }
        public static bool DeleteBookFromLib(string name, string Location)
        {
            bool isFound = false;
            foreach (Book b in Library)
            {
                if (b.Name == name && b.Location == Location)
                {
                    Library.Remove(b);
                    isFound = true;
                    break;
                }
            }
            return isFound;


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