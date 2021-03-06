﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interface;
using WebMVC1.Filters;

namespace WebMVC1.Controllers
{
    //[AuthorizeFilter("role")]
    [RoutePrefix("Test")]
    public partial class HomeController : Controller
    {
        private ITestService testService;

        public HomeController(ITestService testService)
        {
            this.testService = testService;
        }

        [Route("Mvc")]
        [Route("~/")]
        [HttpGet]
        public virtual ActionResult Index()
        {
            var model = this.testService.GetPersons();
            return View(model);
        }

        [AllowAnonymous]
        public virtual ActionResult Login()
        {
            return View();
        }
    }
}
