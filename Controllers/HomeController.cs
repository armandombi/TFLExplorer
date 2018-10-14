using System;
using Microsoft.AspNetCore.Mvc;

namespace CoreTemplate.Controllers
{
   public class HomeController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
   }
}