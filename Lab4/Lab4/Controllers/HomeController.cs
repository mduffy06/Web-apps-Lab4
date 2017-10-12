using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            ViewData["Name"] = "This is my first MVC Application";

            DateTime today = DateTime.Today;
            
            DateTime timeNow = DateTime.Now;
            DateTime endof2017 = new DateTime(2017,12,31);


            DateTime noon = Convert.ToDateTime("12:00:00 PM");
            DateTime six = Convert.ToDateTime("6:00:00 PM");

            if (timeNow < noon)
            {
                ViewData["Greetings"] = "Good Morning";

            }

            else if (timeNow < six && timeNow >= noon)
            {

                ViewData["Greetings"] = "Good Afternoon!";

            }
            
            else if (timeNow >= six)
            {

                ViewData["Greetings"] = "Good Evening!";
            }




            ViewData["Date"] = today.ToString("D");
            ViewData["Time"] = timeNow.ToShortTimeString();

            var daysleft = endof2017.Subtract(today).TotalDays;

            ViewData["DaysLeft"] = daysleft;
            return View();
        }




        public IActionResult Items()
        {



            int[] items = { 123, 44, 29, 1337, 500, 5 };
            return View(items);
        }
    }
}