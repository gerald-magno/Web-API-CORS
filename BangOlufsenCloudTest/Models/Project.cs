using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangOlufsenCloudTest.Models
{
    public class Project
    {
        public Project()
        {

            SkillsGained = new List<string>();
        }
        public Project(string name,string details)
        {
            Name = name;
            Details = details;            
            SkillsGained = new List<string>();
        }

        public Project(string name, string details, string githubUrl)
        {
            Name = name;
            Details = details;

            if (githubUrl.Trim()!= String.Empty)
            {
                IsHobbyProject = true;
                GithubUrl = githubUrl;
            }

            SkillsGained = new List<string>();
        }

        public Project(string name, string details, string githubUrl, List<string> skillsGained, string imageUrl)
        {
            Name = name;
            Details = details;

            if (githubUrl.Trim() != String.Empty)
            {
                IsHobbyProject = true;
                GithubUrl = githubUrl;
            }
            ImageUrl = imageUrl;
            SkillsGained = skillsGained;
        }

        //public int ID { get; private set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public List<string> SkillsGained { get; set; }

        public string GithubUrl { get; set; }

        public string ImageUrl { get; set; }

        public bool IsHobbyProject { get; set; }
    }
}
