using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Task_Day09.Models;
using Task_Day09.RepoServices;

namespace Task_Day09.Controllers
{
    public class TraineeController : Controller
    {
        public ITrackRepository TrackRepository { get; }
        public ICourseRepository courseRepository { get; }
        public ITraineeRepository traineeRepository { get; }
        public TraineeController(ITraineeRepository TraineeRepo,ITrackRepository TrRepo, ICourseRepository CrsRepo)
        {
            traineeRepository = TraineeRepo;
            TrackRepository = TrRepo;
            courseRepository = CrsRepo;
        }

        // GET: TraineeController
        public ActionResult Index()
        {
            ViewBag.Tname = TrackRepository;   
            return View(traineeRepository.GetAll());
        }

        // GET: TraineeController/Details/5
        public ActionResult Details(int id)
        {
            return View(traineeRepository.GetDetails(id));
        }

        // GET: TraineeController/Create
        public ActionResult Create()
        {
            ViewBag.Tracks = TrackRepository.GetAll();
            ViewBag.Coursees = courseRepository.GetAll();
            return View();
        }

        // POST: TraineeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainee trainee)
        {
            try
            {
                traineeRepository.Insert(trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Tracks = TrackRepository.GetAll();
            ViewBag.Coursees = courseRepository.GetAll();
            return View();
        }

        // POST: TraineeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Trainee trainee)
        {
            try
            {
                traineeRepository.UpdateTrainee(id,trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TraineeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Trainee trainee)
        {
            try
            {
                traineeRepository.DeleteTrainee(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
