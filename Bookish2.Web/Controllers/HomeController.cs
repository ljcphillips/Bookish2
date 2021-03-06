﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookish2.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var items = DataAccess.ItemRepository.GetAll();
            ViewBag.Items = items;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}