using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class IssueBooksdl
    {
        public static List<IssueBooks> issue = new List<IssueBooks>();
        public static bool SendReq(IssueBooks i)
        {
            bool isf = true;
            if(isf==true)
            {
                 issue.Add(i);
            }
            else
            {
                return false;
            }

            return isf;
        }
        public static List<IssueBooks> ShowAllReq()
        {
            return issue;
        }
       
    }
}