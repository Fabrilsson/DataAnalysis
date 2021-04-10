using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAnalisysWebApp.Models;

namespace DataAnalisysWebApp.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Settingsasdasd
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Sales()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sales(HumidityViewModel model)
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult Temperature()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Temperature(TemperatureViewModel model)
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult Carbon()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Carbon(CarbonViewModel model)
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult Nutrients()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Nutrients(NutrientsViewModel model)
        //{
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult SensorsActuators()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult SensorsActuators(SensorsActuatorsViewModel model)
        //{
        //    return View();
        //}
    }
}