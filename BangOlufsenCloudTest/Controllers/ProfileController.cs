using System;
using System.Web.Http;
using System.Collections.Generic;
using BangOlufsenCloudTest.Models;
using System.Web.Http.Cors;
namespace BangOlufsenCloudTest.Controllers
{
    
    [EnableCors(origins: "http://dotnetgeekster.azurewebsites.net", headers: "*", methods: "*")]

    public class ProfileController : ApiController
    {
       
        public ProfileController()
        {
           
        }

        // GET api/Profile
        public Profile GetProfile()
        {
            var mySkills = new Profile() {
                Skills = { "C#", "AngularJS", "Bootstrap", "Azure", "JSON", "REST", "HTML5", "CSS3", "LESS", "Grunt", "Bower", "Scrum", "Web API" },
                Summary = "Gerald has 4+ years of professional experience working on complex enterprise software projects. He works with C#, AngularJS, Bootstrap, Azure, REST, Sharepoint/Office 365.",
                PhotoUrl = "/app/assets/images/profpic.jpg"
            };
            return mySkills;
        }

    }
}