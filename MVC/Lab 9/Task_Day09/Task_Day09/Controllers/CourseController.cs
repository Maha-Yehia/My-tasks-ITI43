using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Day09.Models;
using Task_Day09.RepoServices;

namespace Task_Day09.Controllers
{
    public class CourseController : Controller
    {
        public ICourseRepository courseRepository { get; }
        public CourseController(ICourseRepository CourseRepository)
        {
            courseRepository = CourseRepository;
        }
        // GET: CourseController
        public ActionResult Index()
        {
            return View(courseRepository.GetAll());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View(courseRepository.GetDetails(id));
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course crs)
        {
            try
            {
                courseRepository.Insert(crs);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course crs)
        {
            try
            {
                courseRepository.UpdateCourse(id, crs);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                courseRepository.DeleteCourse(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
