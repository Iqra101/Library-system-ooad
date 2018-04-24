using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Book
    {
        private string name;
        private string price;
        private string quantity;
        private string location;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

       
     
        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}