using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string number)
        {
            return View(new TestModel()
            {
                Number = Int32.TryParse(number, out int result) ? result : 0
            });
        }
    }

    public class TestModel 
    {
        public int Number { get; set; }
    }
}