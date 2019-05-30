using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using may27.Models;
namespace may27.Controllers
{
    public class CARSController : Controller
    {

        List<Car> carList = new List<Car>()
        {
            new Car { Id = 1 , Brand = "Toyota ", Model="Corolla", Type = "Compact", Year = 2017},
            new Car { Id = 2 , Brand = "Ford ", Model="F-150", Type = "Truck", Year = 2018},
             new Car { Id = 3 , Brand = "Dodge ", Model="Carvan", Type = "Minivan", Year = 2019}
        };

        // GET: CARS
        public ActionResult Index()
        {
            return View(carList);
        }


        public ActionResult Details(int? id)
        {
            if (id == null || id > carList.Count)
            {
                return Content("invalid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];
            return View(car);
        }
    }
}