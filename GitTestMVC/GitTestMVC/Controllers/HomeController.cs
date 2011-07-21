using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GitTestMVC.Models;

namespace GitTestMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            int d = 4;
            return View();
        }

        public ActionResult GetHomeNews()
        {
            return View("HomeNews", new News[]
                                        {
                                            new News { Subject = "Subject 1", Body = "Body 1"}, new News { Subject = "Subject 2", Body = "Body 2"}
                                        });
        }

    }
}
