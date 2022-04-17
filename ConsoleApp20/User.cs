using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    class User
    {
        private string _username;

        private string _password;

        public User(string username,string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { 
            get 
            {
                return _username;
            } 
            set 
            {
                if (value.Length>6)
                {
                    _username = value;
                }
            }
        }

        

        public string Password {
            get 
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }
        }


        public static bool CheckPassword(string password)
        {
            bool Hasdigit = false;
            bool HasUpper = false;

            if (!string.IsNullOrEmpty(password))
            {
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        Hasdigit = true;
                    }
                    else if (char.IsUpper(item))
                    {
                        HasUpper = true;
                    }
                    if (Hasdigit&&HasUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
