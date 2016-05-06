using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BangOlufsenCloudTest.Models;
using System.Web.Http;
using System.Web.Http.Cors;
namespace BangOlufsenCloudTest.Controllers
{
    [EnableCors(origins: "http://dotnetgeekster.azurewebsites.net", headers: "*", methods: "*")]
    public class PersonController : ApiController
    {

        

        public PersonController()
        {

        }

        // GET api/Person
        public Person GetPerson()
        {
            var myPerson = new Person("Gerald", "Magno", "magno.gerald@gmail.com");
            return myPerson;
        }


              

      
    }
}
