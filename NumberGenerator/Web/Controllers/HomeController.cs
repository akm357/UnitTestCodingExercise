using System;
using System.Web.Mvc;
using Web.WebApiClient;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string txtNumber)
        {
            ViewBag.TxtNumber = txtNumber;
            SequenceData numericSequenceData = new SequenceData();

            if(txtNumber!=null)
            {
                int number = Convert.ToInt32(txtNumber);
                
                ViewBag.allNumbers = numericSequenceData.GetAllNumbers(number);
                ViewBag.allOddNumbers = numericSequenceData.GetAllOddNumbers(number);
                ViewBag.allEvenNumbers = numericSequenceData.GetAllEvenNumbers(number);
                ViewBag.allExtendedFizzBuzzs = numericSequenceData.GetAllExtendedFizzBuzzs(number);
                ViewBag.allFibonacciNumbers = numericSequenceData.GetAllFibonacciNumbers(number);
            }
            return View();
        }
    }
}