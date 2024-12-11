using Microsoft.AspNetCore.Mvc;
using ToDays_Blog.Web.Data;
using ToDays_Blog.Web.Models.Domain;
using ToDays_Blog.Web.Models.ViewModels;

namespace ToDays_Blog.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        private BlogDbContext blogDbContext;
        public AdminTagsController(BlogDbContext newBlogDbContext) 
        {
            blogDbContext = newBlogDbContext;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest)
        {
            var tag = new Tag { 
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName 
            };
            blogDbContext.Tags.Add(tag);
            blogDbContext.SaveChanges();
            return View("Add");
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Edit2()
        {
            return View();
        }
    }
}
