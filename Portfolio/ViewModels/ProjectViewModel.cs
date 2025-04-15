using Portfolio.Models;


namespace Portfolio.ViewModels

{
    public class ProjectViewModel
    {
        private List<Projects> _projects = new List<Projects>()
        {
            new Projects
            {
                projectName = "Axit",
                projectBrief="Simple, stylish webpage built with HTML and CSS.",
                imagePath="/img/portfolio/Axit.png",
                gitHubLink="https://github.com/aminkhaled27/AXIT"
            },
            new Projects
            {
                projectName = "World",
                projectBrief="Modern web project designed to showcase news articles, trending topics.",
                imagePath="/img/portfolio/World.png",
                gitHubLink="https://github.com/aminkhaled27/World"
            },
            new Projects
            {
                projectName = "Tradex",
                projectBrief="A mock stock trading platform for practicing real-time buy and sell operations.",
                imagePath="/img/portfolio/Tradex.png",
                gitHubLink="https://github.com/aminkhaled27/Tradex"
            },
            new Projects
            {
                projectName = "Clone Youtube HB",
                projectBrief="A frontend clone of YouTube's homepage using HTML & CSS.",
                imagePath="/img/portfolio/cyoutbube.png",
                gitHubLink="https://github.com/aminkhaled27/Clone_YouTube"
            },
            new Projects
            {
                projectName = "Smartlabel",
                projectBrief="A smart price tag system with real-time updates via app and web using IoT.",
                imagePath="/img/portfolio/Incomplete.webp",
                gitHubLink = "https://github.com/aminkhaled27/SmartLabel"
            },
            new Projects
            {
                projectName = "college attendance register system",
                projectBrief="An IoT-based attendance system with real-time tracking and multi-platform access.",
                imagePath="/img/portfolio/college-attendance-register-system.png",
                gitHubLink="https://github.com/aminkhaled27/college-attendance-register-system"
            },

        };

        public List<Projects> projects => _projects;
    }
}
