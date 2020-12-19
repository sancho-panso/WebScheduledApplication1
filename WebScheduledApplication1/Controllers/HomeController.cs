using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebScheduledApplication1.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: HomeController
        public ActionResult Index(string message)
        {
            return View(message);
        }

       
    }
}
