using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangOlufsenCloudTest.Models
{
    public class Profile
    {
        public Profile()
        {
            //as empty list
            Skills = new List<string>();
        }
        public Profile(List<string> skills, string summary, string photoUrl)
        {
            Skills = skills;
            Summary = summary;
            PhotoUrl = photoUrl;
        }

        public List<string> Skills { get; set; }
        public string Summary { get; set; }
        public string PhotoUrl { get; set; }

    }
}
