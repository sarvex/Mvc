﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace RazorWebSite.Controllers
{
    public class ViewEngineController : Controller
    {
        public IActionResult ViewWithoutLayout()
        {
            return View();
        }

        public IActionResult ViewWithFullPath()
        {
            return View(@"/Views/ViewEngine/ViewWithFullPath.cshtml");
        }

        public IActionResult ViewWithLayout()
        {
            return View();
        }

        public IActionResult ViewWithNestedLayout()
        {
            return View();
        }

        public IActionResult ViewWithPartial()
        {
            ViewData["TestKey"] = "test-value";
            var model = new Person
            {
                Address = new Address { ZipCode = "98052" }
            };
            return View(model);
        }

        public IActionResult ViewWithPartialTakingModelFromIEnumerable()
        {
            var model = new List<Person>()
            {
                new Person() { Name = "Hello" },
                new Person() { Name = "World" }
            };

            return View(model);
        }

        public ViewResult ViewPassesViewDataToLayout()
        {
            ViewData["Title"] = "Controller title";
            return View("ViewWithTitle");
        }

        public IActionResult ViewWithDataFromController()
        {
            ViewData["data-from-controller"] = "hello from controller";
            return View("ViewWithDataFromController");
        }

        public ViewResult ViewWithComponentThatHasLayout()
        {
            ViewData["Title"] = "View With Component With Layout";
            return View();
        }

        public ViewResult ViewWithComponentThatHasViewStart()
        {
            return View();
        }
    }
}