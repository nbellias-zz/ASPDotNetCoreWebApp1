using ASPDotNetCoreWebApp1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreWebApp1.Controllers
{
    public class FirstController : Controller
    {
        public string Index() // IActionResult Index()
        {
            //return View();
            return "Welcome to this page";
        }

        public IActionResult Hello()
        {
            ViewBag.Message = "A messsage from 'First' controller";
            return View();
        }

        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "Nikolaos Bellias";
            person.Age = 53;
            person.Location = "Greece";

            return View(person);
        }
    }
}
