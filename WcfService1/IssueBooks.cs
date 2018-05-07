using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class IssueBooks
    {
        
        private string UserName;
        private string BookName;

        public string UserName1
        {
            get
            {
                return UserName;
            }

            set
            {
                UserName = value;
            }
        }

        public string BookName1
        {
            get
            {
                return BookName;
            }

            set
            {
                BookName = value;
            }
        }
    }
}