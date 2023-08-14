using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneContacts.Controllers
{
    public class AddController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        [HttpGet]
        public PartialViewResult AddUser()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddUser(User u)
        {
            userManager.TAdd(u);
            return View();
        }
    }
}
