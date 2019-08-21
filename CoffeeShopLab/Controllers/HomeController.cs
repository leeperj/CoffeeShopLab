using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShopLab.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace CoffeeShopLab.Controllers
{

    public class HomeController : Controller
    {
    List<User> registerUser = new List<User>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListUsers()
        {
            return View(registerUser);
        }
        public IActionResult AddUserToList(User user)
        {
            string userJson = HttpContext.Session.GetString("RegisterUserSession");
            if (userJson != null)
            {
                registerUser = JsonConvert.DeserializeObject<List<User>>(userJson);
            }
            registerUser.Add(user);

            HttpContext.Session.SetString("RegisterUserSession", JsonConvert.SerializeObject(registerUser));

            return View("Account", user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
