using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidApp.Models
{
    public class User
    {

        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public MyGender Gender { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsAdmin { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public bool Diagnosed { get; set; }


    }

    public class MyGender
    {
    }
}