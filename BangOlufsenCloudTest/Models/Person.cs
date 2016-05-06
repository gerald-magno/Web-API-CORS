using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BangOlufsenCloudTest.Models
{

    public class Person
    {
        public Person()
        {

        }
        public Person(string fname, string lname, string email)
        {

            FirstName = fname;
            LastName = lname;
            Email = email;

        }
        public Person(int id)
        {

            ID = id;

        }

        public int ID { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        
       
    }
}
