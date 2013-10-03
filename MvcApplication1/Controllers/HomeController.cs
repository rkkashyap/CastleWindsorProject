using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public CastleWindsorInWCF.IMyService _myWrapper { get; set; }
        public  WCFServiceComponent.ICalculator _CalculatorWrapper { get; set; }
        public AnimalLibrary.IAnimal _animal { get; set; }

        public ActionResult Index()
        {
            var test = _myWrapper.GetData(5);
            var sum1 = _CalculatorWrapper.Sum(3, 4);
            
            var speaktest = _animal.Speak();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application." + test + sum1.ToString() + speaktest;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
