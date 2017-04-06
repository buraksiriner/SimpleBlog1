﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog2.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return Content("Admin Area Users Controller List Action");
        }
        public ActionResult Edit(int id = 0)
        {
            return Content("Admin Area Users Controller Edit Action : " + id.ToString());//bunların içeriğini biz yazıyoruz
        }
        public ActionResult brk(int id = 0)
        {
            return Content("Admin Area Users Controller brk Action : " + id.ToString());//bunların içeriğini biz yazıyoruz
        }
        public ActionResult okn(int id = 0)
        {
            return Content("Admin Area Users Controller okn Action : " + id.ToString());//bunların içeriğini biz yazıyoruz
        }
       
    }
}