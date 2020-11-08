using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Tool_World.Models;
using Tool_World.ViewModels;

namespace Tool_World.Controllers
{
    public class ToolsController : Controller
    {
        private ApplicationDbContext _context;

        public ToolsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }

        
        // GET: Tools
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageTools)) 
                return View("List");
                return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {
            var tool = _context.Tools.Include(t => t.Manufacturer).SingleOrDefault(c => c.Id == id);

            if (tool == null)
                return HttpNotFound();

            return View(tool);
        }

        [Authorize(Roles = RoleName.CanManageTools)]
        public ActionResult New()
        {
            var manufacturers = _context.Manufacturers.ToList();

            var toolCategories = _context.ToolCategories.ToList();

            var toolDriveSizes = _context.ToolDriveSizes.ToList();

            var tools = _context.Tools.ToList();

            var viewModel = new ToolFormViewModel
            {
                Manufacturers =  manufacturers,
                ToolCategories = toolCategories,
                ToolDriveSizes = toolDriveSizes
            };

            return View("ToolForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageTools)]
        public ActionResult Save(Tool tool)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ToolFormViewModel(tool)
                {
                    Manufacturers = _context.Manufacturers.ToList(),
                    ToolCategories = _context.ToolCategories.ToList(),
                    ToolDriveSizes = _context.ToolDriveSizes.ToList(),
                };

                return View("ToolForm", viewModel);
            }
            
            if (tool.Id == 0)
                _context.Tools.Add(tool);

            else
            {
                var toolInDb = _context.Tools.Single(t => t.Id == tool.Id);

                toolInDb.ModelName = tool.ModelName;
                toolInDb.ToolDriveSizeId = tool.ToolDriveSizeId;
                toolInDb.ManufacturerId = tool.ManufacturerId;
                toolInDb.ToolCategoryId = tool.ToolCategoryId;
                toolInDb.NumberInStock = tool.NumberInStock;
                toolInDb.UrlPicLink = tool.UrlPicLink;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Tools");
        }
        [Authorize(Roles = RoleName.CanManageTools)]
        public ActionResult Edit(int id)
        {
            var tool = _context.Tools.SingleOrDefault(t => t.Id == id);

            if (tool == null)
                return HttpNotFound();

            var viewModel = new ToolFormViewModel(tool)
            {
                
                Manufacturers = _context.Manufacturers.ToList(),
                ToolCategories = _context.ToolCategories.ToList(),
                ToolDriveSizes = _context.ToolDriveSizes.ToList(),
            };

            return View("ToolForm", viewModel);
        }
    }
}