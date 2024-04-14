using Azure;
using LoginApplication1.DatabaseLayer;
using LoginApplication1.Entity;
using LoginApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
        public ActionResult Signup()
        {
            return View();
        }
        
        
        [HttpPost]
        public ActionResult Signup(Signup model)
        {

            if (ModelState.IsValid)
            {
                DataLayer Db = new DataLayer();
                Db.InsertData(model);
                TempData["SignupResult"] = "Success";
                return RedirectToAction("SignupResult");
            }
            TempData["SignupResult"] = "Failure";
            return RedirectToAction("SignupResult");
        }
        public ActionResult SignupResult()
        {
            var signupResult = TempData["SignupResult"] as string;

            if (signupResult == "Success")
            {
                ViewBag.SignupResult = "Success";
            }
            else {
                ViewBag.SignupResult = "Failure";
            }
            return View();
        }
            [HttpPost]
        public ActionResult Index(Signup model)
        { 
    
            TempData["userid"] = model.Email;
            TempData["password"] = model.Password;
            return RedirectToAction("Details");
        }


        public ActionResult Details()
        {
            DataLayer data = new DataLayer();
            List<Signup> loginData = data.GetAllLogin();

            bool isValidtrue = false;

            var UserID = TempData["userid"] as string;
            var Password = TempData["password"] as string;
            

            for (int i = 0; i < loginData.Count(); i++)
            {
                if (loginData[i].Email == UserID && loginData[i].Password == Password)
                {
                    isValidtrue = true;
                    break;
                }
            }


            if (isValidtrue == true)
            {
                ViewBag.Status = "success";
            }
            else
            {
                return RedirectToAction("Signup");
            }

            return View();
        }
       


    }
}
