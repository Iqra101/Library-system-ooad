using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class User
    {
        private string username;
        private string password;
        private string secretQuestion;
        private string secretAnswer;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string SecretQuestion
        {
            get
            {
                return secretQuestion;
            }

            set
            {
                secretQuestion = value;
            }
        }

        public string SecretAnswer
        {
            get
            {
                return secretAnswer;
            }

            set
            {
                secretAnswer = value;
            }
        }
    }
}