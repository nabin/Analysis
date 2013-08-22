using BIAnalysisApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIAnalysisApp.Controllers
{
    public class CustomerCardController : Controller
    {

        private readonly ICustomerCardService service;
        public CustomerCardController(ICustomerCardService service)
        {
            this.service = service;    
        }

        //
        // GET: /CustomerCard/
        public ActionResult Index()
        {
            return View();
        }

        //Data:
        /// <summary>
        /// Get all installation and return 
        /// </summary>
        /// <returns></returns>
        public JsonResult GetInstallation()
        {
            var installations = service.GetInstallations().ToList();

            return Json(installations, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult GetLocations(string installationsdata)
        {
            var locations = service.GetLocations().ToList();

            return Json(locations);

        }

        [HttpPost]
        public JsonResult GetDepartments(string installationsdata, string locationdata)
        {
            var departments = service.GetDepartments().ToList();

            return Json(departments);
        }

        [HttpPost]
        public JsonResult GetCustomers(string installationsdata, string locationdata)
        {
            var departments = service.GetCustomers().ToList();

            return Json(departments);
        }

        [HttpPost]
        public JsonResult GetCards(string installationsdata, string locationdata)
        {
            var departments = service.GetCards().ToList();

            return Json(departments);
        }

        [HttpPost]
        public JsonResult GetCompanies(string installationsdata, string locationdata)
        {
            var departments = service.GetCompanies().ToList();

            return Json(departments);
        }
       


    }
}
