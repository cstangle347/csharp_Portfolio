using System;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult AboutMe()
        {
            return View("AboutMe");
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }

        [HttpGet("submit")]
        public RedirectResult Submit()
        {
            return Redirect("/");
        }
    }
}