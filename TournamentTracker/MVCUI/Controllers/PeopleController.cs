using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace MVCUI.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            List<PersonModel> availablePeople = GlobalConfig.Connection.GetPerson_All();
            return View(availablePeople);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(PersonModel p)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                    GlobalConfig.Connection.CreatePerson(p);

                    return RedirectToAction("Index"); 
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
