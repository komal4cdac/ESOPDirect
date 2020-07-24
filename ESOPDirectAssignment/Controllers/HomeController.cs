using ESOPDirectAssignment.Calculator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESOPDirectAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult CalculateFactorial(int number)
        {
            float result;
            FactorialCalculator factorialCalculator = new FactorialCalculator();
           result =  factorialCalculator.GetFactorial(number);
            Process process = new Process();
            process.SaveToServer(number,result);
            
            return Json(result, "application/json");
        }
    }
}