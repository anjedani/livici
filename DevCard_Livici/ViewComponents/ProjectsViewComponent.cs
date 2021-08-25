using DevCard_Livici.Models;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace DevCard_Livici.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent

    {
            public IViewComponentResult Invoke()
            {

                var halim = new List<Project>
                {

                    new Project(1,"googooli","11111","project-1.jpg","dfsdfsdf"),
                    new Project(2,"googooli2","22222","project-2.jpg","dfsdfsdf"),
                    new Project(3,"googooli3","333333","project-3.jpg","dfsdfsdf"),
                    new Project(4,"googooli4","project-4","project-4.jpg","dfsdfsdf")
                };
            

             return View("jakesh",halim);

            }

    }
}
