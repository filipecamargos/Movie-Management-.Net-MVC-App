using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    //the controloer is the name before controller Index() is default and Welcome() is a seconde method
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            //Uses HtmlEncoder.Default.Encode to protect the app from malicious input, such as through JavaScript.
            //Uses Interpolated Strings in $"Hello {name}, NumTimes is: {numTimes}"
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}