using DevCard_Livici.Models;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace DevCard_Livici.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {


            var maghale = new List<Article>
            {
            new Article(1,"jhdjg","1دسکریپشن","blog-post-thumb-card-1.jpg"),
            new Article(2,"gh","دسکریپشن2","blog-post-thumb-card-2.jpg"),
            new Article(3,"hh","3دسکریپشن","blog-post-thumb-card-3.jpg"),
            new Article(4,"jjj","4دسکریپشن","blog-post-thumb-card-4.jpg")

            };
             return View("Maghalat",maghale);
        }
    }
}