using System.Web.Mvc;
using CalculateMinLOb.TwoArgumentsFolder;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace WebInterface.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "mult", Text ="Multiply"
                },
                new SelectListItem()
                {
                    Value = "add", Text ="Addition"
                },
                new SelectListItem()
                {
                    Value = "minus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "div", Text ="Division"
                }
            };
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

        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "mult", Text ="Multiply"
                },
                new SelectListItem()
                {
                    Value = "add", Text ="Addition"
                },
                new SelectListItem()
                {
                    Value = "minus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "div", Text ="Division"
                }
            };
            return View();
        }
    }
}