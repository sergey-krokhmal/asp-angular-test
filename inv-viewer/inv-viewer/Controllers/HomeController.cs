using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InvViewer.Models;
using InvViewer.DAL;

namespace InvViewer.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            InventoryContext db = new InventoryContext();
            var buildings = new List<Building>
            {
                new Building{Name="house 1"},
                new Building{Name="Building 1"}
            };
            buildings.ForEach(b => db.Buildings.Add(b));
            db.SaveChanges();
            var tmp = db.Buildings;
            return View(tmp);
        }

    }
}
