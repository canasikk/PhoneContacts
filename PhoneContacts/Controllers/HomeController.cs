using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneContacts.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneContacts.Controllers
{
    public class HomeController : Controller
    {
         
      
        public IActionResult Index()
        {
             
            return View();
        } 
         
    }
}
