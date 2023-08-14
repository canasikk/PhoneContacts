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
    public class DeleteController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());

        [HttpGet]
        public PartialViewResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Index(User u)
        { 
            userManager.TDelete(u);
            return RedirectToAction("Read","Index");
        }

    }
}
