using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class Book
    {
        [DataMember]
        private string name;
        [DataMember]
        private string price;
        [DataMember]
        private string quantity;
        [DataMember]
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