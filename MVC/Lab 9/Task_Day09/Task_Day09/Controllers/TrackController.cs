using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Day09.Models;
using Task_Day09.RepoServices;

namespace Task_Day09.Controllers
{
    public class TrackController : Controller
    {
        // GET: TrackController
        public ITrackRepository trackRepository { get; }
        public TrackController(ITrackRepository TrackRepository)
        {
            trackRepository = TrackRepository;
        }
        public ActionResult Index()
        {
            return View(trackRepository.GetAll());
        }

        // GET: TrackController/Details/5
        public ActionResult Details(int id)
        {
            return View(trackRepository.GetDetails(id));
        }

        // GET: TrackController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrackController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Track track)
        {
            try
            {
                trackRepository.Insert(track);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrackController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrackController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Track track)
        {
            try
            {
                trackRepository.UpdateTrack(id,track);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrackController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                trackRepository.DeleteTrack(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
