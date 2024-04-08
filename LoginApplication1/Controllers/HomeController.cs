using LoginApplication1.DatabaseLayer;
using LoginApplication1.Entity;
using LoginApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoginApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Create model)
        {
            TempData["username"] = model.username;
            TempData["password"] = model.password;
            return RedirectToAction("Details");
        }


        public ActionResult Details()
        {
            DataLayer data = new DataLayer();
            List<Create> loginData = data.GetAllLogin();

            bool isValidtrue = false;

            var username = TempData["username"] as string;
            var password = TempData["password"] as string;

            for (int i = 0; i < loginData.Count(); i++)
            {
                if (loginData[i].username == username && loginData[i].password == password)
                {
                    isValidtrue = true;
                }
            }

            ViewBag.Status = isValidtrue == true ? "Success, User exists in DB" : "User doesn't exists in DB";
            return View();
        }
    }
}
