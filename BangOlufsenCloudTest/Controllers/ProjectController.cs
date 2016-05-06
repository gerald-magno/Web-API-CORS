
using System.Web.Http.Cors;
using System.Collections.Generic;
using System.Web.Http;
using BangOlufsenCloudTest.Models;
using System;

namespace BangOlufsenCloudTest.Controllers
{
    [EnableCors(origins: "http://dotnetgeekster.azurewebsites.net", headers: "*", methods: "*")]
    public class ProjectController : ApiController
    {

        
        public IEnumerable<Project> GetProjects()
        {
            var myProjects = new List<Project>()
            {
                new Project {
                    Name = "Microsoft Graph ASPNET Webhooks",
                    Details = "Creating webhook subscription for specific Mail folders to get notified about changes in your app.",
                    SkillsGained = {"JSON.NET","C#", "async","Microsoft Graph", "Oauth" },
                    IsHobbyProject = true,
                    GithubUrl="https://github.com/gerald-magno/Microsoft-Graph-ASPNET-Webhooks",
                    ImageUrl="/app/assets/images/specific-mail-folder-subscr.png"
                },
                 new Project {
                    Name = "InventoryApp",
                    Details = "An application for consignment sales and inventory. Manage vendors, products, product stock, pull out of products by vendors, generate reports of sales by vendor and inventory.",
                    SkillsGained = {"C#","NUnit","SQL","ADO.NET", "Crystal Reports", "Winforms" },
                    IsHobbyProject = true,
                    GithubUrl="https://github.com/gerald-magno/InventoryApp",
                    ImageUrl="/app/assets/images/inventoryApp.png"
                },
                 new Project {
                    Name = "Office 365 Team site - SPA",
                    Details = "A large scale SPA project using AngularJS 1 that consumes and interacts with REST API to get Office 365 data",
                    SkillsGained = {"AngularJS", "Bootstrap","GruntJS", "Bower", "HTML5", "CSS3","Office 365", "Sharepoint", "Oauth" },
                    IsHobbyProject = false,
                    GithubUrl=""
                },

                  new Project {
                    Name = "Showcase site - SPA",
                    Details = "A modular and responsive Single Page App using AngularJS 1 and consumes REST Web API.",
                    SkillsGained = {"AngularJS", "Bootstrap", "HTML5", "CSS3", "ANGM Generator", "angular directives", "Azure" },
                    IsHobbyProject = true,
                    GithubUrl="https://dotnetgeekster.azurewebsites.net"
                },

                   new Project {
                    Name = "Showcase site data - Web API",
                    Details = "The backend for the showcase site using REST Web API and CORS.",
                    SkillsGained = {"Web API", "CORS", "Azure" },
                    IsHobbyProject = true,
                    GithubUrl="https://dotnetgeeksterdata.azurewebsites.net"
                }
            };

              
            return myProjects;
        }
    }
}
