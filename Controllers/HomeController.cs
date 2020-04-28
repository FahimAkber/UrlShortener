using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UShortener.Models;

namespace UShortener.Controllers
{
    public class URLResponse{
        public string url{get; set;}
        public string status{get; set;}
        public string token{get; set;}
    }

    public class HomeController : Controller
    {
       
        
        public IActionResult Index()
        {
            return View();
        }


    }
}
