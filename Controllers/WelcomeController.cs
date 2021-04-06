using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcFirst.Models;

namespace MvcFirst.Controllers
{
    public class WelcomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public WelcomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

[BindProperty(SupportsGet = true)]

public string Message {get;set;}



        //public string Greet(string message, int? id = 1){
        //public string Greet( int id = 1){

            public IActionResult Greet( int id = 1){


            if (!string.IsNullOrEmpty(Message)){
                string msg ="";
                for (int i = 0; i <id; i++){

                        msg+= HtmlEncoder.Default.Encode(Message) + "<br>";
                }
                //return msg;

                ViewBag.msg = msg;

            }
            else{

                ViewBag.msg = "test";
            }

            //return "no message";

            return View();
        }

        public string Index()
        {
            return "Hi";
        }

        public string Bye()
        {

            return "bye";
        }

    }
}
