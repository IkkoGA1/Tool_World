using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tool_World.Models;
using System.Data.Entity;
using Tool_World.ViewModels;

namespace Tool_World.Controllers
{
    public class ToolRentalsController : Controller
    {
        private ApplicationDbContext _context;


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ToolRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: ToolRentals
        public ActionResult New()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Edit()
        {
            return View("Edit");
        }

        
    }
}