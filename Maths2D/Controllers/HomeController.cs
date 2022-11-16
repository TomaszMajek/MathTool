using Maths2D.Data;
using Maths2D.Models;
using Maths2D.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Maths2D.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository _postRepository;

        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            var getPosts = _postRepository.GetAllPosts();
            return View(getPosts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    post.Created = DateTime.Now.ToShortDateString();
                    bool addPost = _postRepository.AddPost(post);
                    return RedirectToAction("Index");
                }
            } 
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to add new post. Try again, and if the problem persists see your system administrator.");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}