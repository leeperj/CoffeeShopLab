using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopLab.Controllers
{
    public class CoffeeShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserForm()
        {
            return View(new User());
        }


        [HttpPost]
        public IActionResult UserForm(User newUser)
        {
            return RedirectToAction("AddUser", newUser);
        }

        public IActionResult AddUser(User user)
        {
            return View(user);
        }

    }
}