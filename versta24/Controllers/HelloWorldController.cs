using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace versta24.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        //
        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name = "Texter", int numTimes = 1)
        {
            ViewData["Message"] = "Привет, " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
