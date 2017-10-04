using _14DTHC5Web.Models;
using _14DTHC5Web.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace _14DTHC5Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CoursesController()
        {
            this.dbContext = new ApplicationDbContext();
        }
        /// NEW CODE - NO DEV & LEADER CODE
        /// <summary>
        /// Create New Course
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateCourse()
        {
            var courseViewModel = new CourseViewModel()
            {
                Categories = dbContext.Categories.ToList()
            };
            return View(courseViewModel);
        }
    }
}