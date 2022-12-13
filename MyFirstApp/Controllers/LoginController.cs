using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models;

namespace MyFirstApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.UserName == "BillGates" && userModel.Password == "bigbucks")
            {
                return View("LoginSuccess", userModel);
            } else
            {
                View("LoginFailure", userModel);
            }

        }
    }
}