using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AddBookToLib(string name, string Location, string Quantity)
        {
            Book b = new Book();
            b.Name = name;
            b.Location = Location;
            b.Quantity = Quantity;
            Bookdl.AddBookToLib(b);
        }

        public bool DeleteBookFromLib(string name, string Location)
        {
            return Bookdl.DeleteBookFromLib(name, Location);
        }
        public bool DeleteBookFromMar(string name, string location)
        {
            return Bookdl.DeleteBookFromMar(name, location);
        }
        public bool UpdateQuantity(string name, string Location, string quantity)
        {
            return Bookdl.UpdateQuantity(name, Location, quantity);
        }
        public bool UpdatePrice(string name, string Location, string price)
        {
            return Bookdl.UpdatePrice(name, Location, price);
        }
        public bool IssueBook(string name, string Location, string Quantity)
        {
            return Bookdl.IssueBook(name, Location, Quantity);
        }
        public bool forgetpassword(string username, string question, string answer)
        {
            bool isFound = false;
            foreach (User u in Userdl.user)
            {
                if (u.Username==username && u.SecretAnswer==answer)
                {
                    isFound = true;
                }
            }
            return isFound;
        }
        public bool SendReq(string username, string bookname)
        {
            bool isf = false;
            IssueBooks i = new IssueBooks();
            i.UserName1 = username;
            i.BookName1 = bookname;
            foreach (User u in Userdl.user)
            {
                if (u.Username == username)
                {
                    foreach (Book b in Bookdl.Library)
                    {
                        if (b.Name == bookname)
                        {
                            isf = true;
                            
                            IssueBooksdl.SendReq(i);
                        }
                    }
                }
            }
            return isf;

        }
        public List<IssueBooks> ShowAllReq()
        {
            return IssueBooksdl.ShowAllReq();
        }
       
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool isvalidAdmin(string username, string password)
        {
            bool isFound = false;
            Admin a = new Admin();
            if (username == a.username && password== a.password)
            {
                isFound = true;
            }
            return isFound;
        }

        public bool isvaliduser(string username, string password)
        {
            bool isFound = false;
            foreach (User u in Userdl.user)
            {
                if (u.Username == username && u.Password==password)
                {
                    isFound = true;
                }
            }
            return isFound;
        }

        public void registration(string username, string password, string q, string a)
        {
            User u = new User();
            u.Username = username;
            u.Password = password;
            u.SecretQuestion = q;
            u.SecretAnswer = a;
            Userdl.user.Add(u);
        }

        public void resetpassword(string username, string password)
        {
           foreach(User u in Userdl.user)
            {
                if(u.Username == username)
                {
                    u.Password = password;
                }
            }
        }

        public void AddBooksToMar(string name, string location, string price)
        {
            Book b = new Book();
            b.Name = name;
            b.Location = location;
            b.Price = price;
            Bookdl.AddBookToMar(b);
        }

        public List<Book> ShowAllBooksLib()
        {
            return Bookdl.ShowAllBooksLib();
        }

        public List<Book> ShowAllBooksMar()
        {
            return Bookdl.ShowAllBooksMar();
        }

        public List<Book> SearchBookFromLib(string name)
        {
            return Bookdl.SearchBookFromLibrary(name);
        }

        public List<Book> SearchBookFromMar(string name)
        {
            return Bookdl.SearchBookFromMar(name);
        }
    }
}
