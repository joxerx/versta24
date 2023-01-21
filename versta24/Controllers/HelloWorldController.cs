using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace versta24.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action! Лежит в индексе";
        }
        //
        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method! В приветствии";
        }
    }
}
