﻿using IServices;
using IServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Infrastructura;

namespace WebApplication4.Controllers
{
    public class BaseController : Controller
    {
        public IMainServices Services { get; set; }

        public BaseController()
        {
            Services = DependencyResolver.Current.GetService<IMainServices>();
            User = WebUser.CurrentUser;
        }

        public new ModelUser User { get; set; }
    }
}