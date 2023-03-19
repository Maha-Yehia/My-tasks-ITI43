using Microsoft.AspNetCore.Mvc;
using Task1.Model;

namespace Task1.Control
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult GetAllCars()
        {
            List<Car> carList = CarList.Cars;
            ViewBag.cars = carList;
            return View();
        }

        public ActionResult SelectCarById(int num)
        {
            ViewBag.selectedCar = CarList.Cars.FirstOrDefault(c => c.Num == num);

            return View();
        }
        public ActionResult DeleteCar(int num)
        {
            var deletedCar = CarList.Cars.FirstOrDefault(c => c.Num == num);
            CarList.Cars.Remove(deletedCar);

            return RedirectToAction("GetAllCars");
            //return View("GetAllCars"); proceeded for the old list 
        }
        public ActionResult EditCar(int num)
        {
            ViewBag.selectedCar = CarList.Cars.FirstOrDefault(c => c.Num == num);

            return View();
        }
        [HttpPost]
        public ActionResult EditCar(int num, string color, string manufacture, string model)
        {
            Car myCar = CarList.Cars.FirstOrDefault(c => c.Num == num);
            myCar.Color = color;
            myCar.Manufacture = manufacture;
            myCar.Model = model;
            return RedirectToAction("GetAllCars");
        }

        public ActionResult CreateNewCar()
        {
            ViewBag.lastNum = CarList.Cars.Count + 1;

            return View();
        }
        [HttpPost]
        public ActionResult CreateNewCar(int num, string color, string model, string manufacture)
        {

            Car newCar = new Car();
            newCar.Num = num;
            newCar.Color = color;
            newCar.Manufacture = manufacture;
            newCar.Model = model;
            CarList.Cars.Add(newCar);
            return RedirectToAction("GetAllCars");

        }
    }
}