using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Project.Models;

namespace ASP.NET_Project.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return Content("No Account selected");
        }

        public IActionResult Show(int id)
        {
            //creae instance of model Account
            Account act = new Account();
            if (id == 1) 
            {  
               act.FirstName = "Brett"; 
               act.LastName = "Smith"; 
               act.UserName = "bsmith";
               act.Password = "password"; 
            }
            else
            {
                act.FirstName = "Joe";
                act.LastName = "Snuffy";
                act.UserName = "jsnuffy";
                act.Password = "password";
            }

            return View(act);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
