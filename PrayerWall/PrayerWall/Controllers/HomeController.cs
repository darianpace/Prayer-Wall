using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrayerWall.Models;

namespace PrayerWall.Controllers
{
    public class HomeController : Controller
    {
        PrayerWallDbContext db;

        public HomeController(PrayerWallDbContext db)
        {
            this.db = db;
            
        }

        public void SaveAccess()
        {
            db.PageAccesses.Add(new PageAccess()
            {
                ActionName = ControllerContext.ActionDescriptor.ActionName,
                ControllerName = ControllerContext.ActionDescriptor.ControllerName
                
            });

            db.SaveChanges();
        }

        public IActionResult Index()
        {
            
            return View();
        }

       
        public IActionResult PrayerRequest()
        {
            
            return View();
        }

        public IActionResult PrayerChain()
        {
            
            return View();
        }

        public IActionResult ErrorMessage()
        {
            
            return View();
        }

        public IActionResult VideoRepository()
        {
            
            return View();
        }

        

    }
}
