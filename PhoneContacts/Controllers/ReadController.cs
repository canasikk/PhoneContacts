using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneContacts.Controllers
{
    public class ReadController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        public IActionResult Index()
        {
            var values = userManager.TGetList();
            return View(values);
        }
    }
}
