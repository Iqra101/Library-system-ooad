﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class Bookdl
    {
        [DataMember]
        public static List<Book> Library = new List<Book>();
        [DataMember]
        public static List<Book> Market = new List<Book>();
        public static void AddBookToLib(Book b)
        {
            Library.Add(b);
            
        }
        public static void AddBookToMar(Book b)
        {
            Market.Add(b);
        }
        public static void UpdatePrice(Book b)
        {

        }
        public static bool UpdateQuantity(string name, string Location, string quantity)
        {
            bool isUpdated = false;
            foreach(Book b in Library)
            {
                if(b.Name==name && b.Location==Location)
                {
                    b.Quantity = quantity;
                    isUpdated = true;
                }
            }
            return isUpdated;
        }
        public static bool UpdatePrice(string name, string Location, string price)
        {
            bool isUpdated = false;
            foreach (Book b in Market)
            {
                if (b.Name == name && b.Location == Location)
                {
                    b.Price = price;
                    isUpdated = true;
                }
            }
            return isUpdated;
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
        public static bool DeleteBookFromMar(string name, string location)
        {
            bool isFound = false;
            foreach(Book b in Market)
            {
                if(b.Name == name && b.Location == location)
                {
                    Market.Remove(b);
                    isFound = true;
                    break;
                }
            }
            return isFound;
        }
        public static List<Book> SearchBookFromLibrary(string name)
        {
            List<Book> books = new List<Book>();
            foreach(Book b in Library)
            {
                if(b.Name == name)
                {
                    books.Add(b);
                }
            }
            return books;
        }
        public static List<Book> SearchBookFromMar(string name)
        {
            List<Book> books = new List<Book>();
            foreach (Book b in Market)
            {
                if (b.Name == name)
                {
                    books.Add(b);
                }
            }
            return books;
        }
        public static List<Book> ShowAllBooksLib()
        {
            return Library;
        }
        public static List<Book> ShowAllBooksMar()
        {
            return Market;
        }
    }
}