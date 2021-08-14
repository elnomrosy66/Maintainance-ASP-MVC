using Maintainance.Helpers.Image;
using Maintainance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maintainance.Controllers
{
    public class WorkController : Controller
    {
        private ApplicationDbContext _context;
        Image image = new Image();
        public WorkController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Work
        public ActionResult Index()
        {
            var alldata = _context.ourWorks.ToList();
            return View(alldata);
        }
        
        public ActionResult CreateWork()
        {
            return PartialView();
        }

        public ActionResult Create(OurWork ourwork)
        {
            if (!ModelState.IsValid)
            {
                return View("index", "work", ourwork);
            }
            if (image.insertimage(ourwork))
            {
                _context.ourWorks.Add(ourwork);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}