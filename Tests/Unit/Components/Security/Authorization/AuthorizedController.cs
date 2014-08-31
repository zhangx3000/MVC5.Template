﻿using MvcTemplate.Components.Security;
using System.Web.Mvc;

namespace MvcTemplate.Tests.Unit.Components.Security
{
    [GlobalizedAuthorize]
    public class AuthorizedController : Controller
    {
        [HttpGet]
        public ActionResult NotAttributedGetAction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NotAttributedPostAction()
        {
            return View();
        }

        [HttpGet]
        [GlobalizedAuthorize]
        public ActionResult AuthorizeGetAction()
        {
            return View();
        }

        [HttpPost]
        [GlobalizedAuthorize]
        public ActionResult AuthorizePostAction()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public virtual ActionResult AllowAnonymousGetAction()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult AllowAnonymousPostAction()
        {
            return View();
        }

        [HttpGet]
        [AllowUnauthorized]
        public ActionResult AllowUnauthorizedGetAction()
        {
            return View();
        }

        [HttpPost]
        [AllowUnauthorized]
        public ActionResult AllowUnauthorizedPostAction()
        {
            return View();
        }
    }
}
