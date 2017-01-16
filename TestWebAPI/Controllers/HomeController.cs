﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace TestWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public string OpenModelPopup()
        {
            //can send some data also.
            return "<h1>Success</h1>";
        }

        public void GetProductList()
        {
            var result = new ProductController().GetProducts();
        }
    }
}