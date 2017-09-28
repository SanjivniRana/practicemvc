using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practicemvc.Models;

namespace practicemvc.Controllers
{
    public class HomeController : Controller
    {
        MyContext context = new MyContext();
     
        // GET: Home
        public ActionResult Index()
        {
            return View(context.dbases.ToList());
        }

        public ActionResult New()
        {
            var memberType = context.MemberTypes.ToList();
            var viewModel = new NewDataViewModel
            {
                dbase = new dbase(),
                MemberTypes = memberType
            };
            return View("New",viewModel);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(dbase db)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewDataViewModel
                {
                    dbase = db,
                    MemberTypes = context.MemberTypes.ToList()
                };

                return View("New", viewModel);
            }

            if (db.Id == 0)
                context.dbases.Add(db);
            else
            {
                var customerInDb = context.dbases.Single(c => c.Id == db.Id);
                customerInDb.Name = db.Name;
                customerInDb.Birthdate = db.Birthdate;
                customerInDb.MembershipTypeId = db.MembershipTypeId;

            }

            context.SaveChanges();

            return RedirectToAction("Index", "dbases");
        }
    }
}