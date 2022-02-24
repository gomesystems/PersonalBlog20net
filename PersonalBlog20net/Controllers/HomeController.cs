using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalBlog20net.Models;
using PersonalBlog20net.Services;
using System.Diagnostics;

namespace PersonalBlog20net.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogServices _blogService;

        public HomeController(ILogger<HomeController> logger,
            IBlogServices blogService)
        {
            _logger = logger;
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult LatestBlogPost()
        {
            var posts = _blogService.GetLatestPosts();
            return Json(posts);
			
			//var posts = new List<BlogPost>() {
            //    new BlogPost { PostId = 1, Title = "xxx", ShortDescription = "xxx" },
            //    new BlogPost { PostId = 2, Title = "xxx", ShortDescription = "xxx" },
            //    new BlogPost { PostId = 3, Title = "xxx", ShortDescription = "xxx" },
            //    new BlogPost { PostId = 4, Title = "xxx", ShortDescription = "xxx" },
            //    new BlogPost { PostId = 5, Title = "xxx", ShortDescription = "xxx" }
            //};
        }
    }
}

