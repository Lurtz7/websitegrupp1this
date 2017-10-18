using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQLLibrary
{
    public class Customer
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SSN { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // A user should never be created without username/password etc
        private Customer()
        {

        }

        public Customer(int id, string firstname, string lastname, string ssn, string email, string password)
        {
            ID = id;
            Firstname = firstname;
            Lastname = lastname;
            SSN = ssn;
            Email = email;
            Password = password;
        }

        public Customer(int id, string firstname, string lastname, string email)
        {
            ID = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
        }
    }

}