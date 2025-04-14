using Microsoft.VisualBasic;
using Portfolio.Models;

namespace Portfolio.ViewModels
{
    public class AboutViewModel
    {
        private List<About> _info = new List<About>
        {
            new About
            {
                Birthday = "27 July 2004",
                Website = "https://www.linkedin.com/in/amin-khaled-ragab/",
                Phone = "+201202155490",
                City = "Tanta, Egypt",
                Age = "21",
                Degree = "Bachelor's",
                Email = "amin.kh.ragab@gmail.com",
                Freelance = "Available"
            }
        };
        public List<About> Info => _info;

        private List<Stats> _stats = new List<Stats>
        {
            new Stats
            {
                H_CLients = 25,
                Projects = 5,
                HoursOfSupport= 150,
                HardWorkers = 10
            }
        };

        public List<Stats> Stats => _stats;

        private List<Skills> _skills = new List<Skills>
        {
            new Skills
            {
                skill1="C#",
                skill1_rate=90,

                skill2="ASP.NET Core",
                skill2_rate=90,

                skill3 = "Entity Framework Core",
                skill3_rate= 80,

                skill4= "RESTful API Development",
                skill4_rate=70,

                skill5= "Microservices Architecture",
                skill5_rate=80,

                skill6="SQL Server",
                skill6_rate=90
            }
        };

        public List<Skills> Skills => _skills;
    }
}
