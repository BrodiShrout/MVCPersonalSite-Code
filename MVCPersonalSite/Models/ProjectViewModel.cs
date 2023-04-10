using Microsoft.AspNetCore.Mvc;

namespace MVCPersonalSite.Models
{
    public class ProjectViewModel
    {
        public int ID { get; set; }
        public string Thumbnail { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Filter { get; set; } = null!;
        public string? URL { get; set; }
        public string GitHub { get; set; } = null!;
        public string Image1 { get; set; } = null!;

        public DateTime ProjectDate { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }

        public static List<ProjectViewModel> GetProjects()
        {
            var project1 = new ProjectViewModel()
            {
                Name = "Dungeon Application  information",
                ProjectDate = new DateTime(2023, 3, 06),
                Description = "This it is a .NET Core Console Application where the foundational concepts of C# as a language were learned.\r\n" +
                "Objective of This Project:\r\n" +
                "The Dungeon Application is intended to showcase your C# skills. It will allow you to demonstrate your ability to break down multi-stage processes into steps and to design complex logical structures. ",
                ID = 1,
                Thumbnail = "~/newDungeonApp.png",
                URL = null,
                GitHub = "https://github.com/BrodiShrout/DungeonApplication",
                Image1 = "~/images/Da-Code-1.png",
                Image2 = "~/images/Da-Code-2.png",
                Image3 = "~/images/Da-Code-3.png",
                Filter = "~/app"

            };
            var project2 = new ProjectViewModel()
            {
                Name = " Storefront Application ",
                ProjectDate = new DateTime(2023, 5, 19),
                Description = " While at Centriq, I was tasked with building a mock e-commerce site. I've already designed the database that will be used for the application. Currently, I'm working on expanding the functionality of the application using MVC classes. Once that is complete GitHut link will be posted! ",
                ID = 2,
                Thumbnail = "~/storefront.png",
                URL = null,
                GitHub = "",
                Image1 = "storefront.png",
                Image2 = "storefront.png",
                Image3 = "storefront.png",
                Filter = "web"
            };
            var project3 = new ProjectViewModel()
            {
                Name = "ReactToDo ",
                ProjectDate = new DateTime(2023, 5, 19),
                Description = " Under Construction ",
                ID = 3,
                Thumbnail = "REACT.png",
                URL = null,
                GitHub = "",
                Image1 = "REACT.png",
                Image2 = "REACT.png",
                Image3 = "REACT.png",
                Filter = "app"

            };
            var project4 = new ProjectViewModel()
            {
                Name = " ToDo API ",
                ProjectDate = new DateTime(2023, 5, 19),
                Description = " Under Construction ",
                ID = 4,
                Thumbnail = "API.png",
                URL = null,
                GitHub = "",
                Image1 = "API.png",
                Image2 = "API.png",
                Image3 = "API.png",
                Filter = "card"
            };
            var project5 = new ProjectViewModel()
            {
                Name = " SAT ",
                ProjectDate = new DateTime(2023, 5, 19),
                Description = " Under Construction ",
                ID = 5,
                Thumbnail = "SAT.png",
                URL = null,
                GitHub = "",
                Image1 = "SAT.png",
                Image2 = "SAT.png",
                Image3 = "SAT.png",
                Filter = "web"

            };
            return new List<ProjectViewModel> { project1, project2, project3, project4, project5 };
        }
    }
}
