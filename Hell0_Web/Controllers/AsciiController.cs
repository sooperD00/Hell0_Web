﻿using Hell0_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Hell0_TDD.Core;

namespace Hell0_Web.Controllers
{
    public class AsciiController : Controller
    {
        public AsciiController() { } // Explicit, ensures tests can instantiate

        // GET: /Ascii/Input
        [HttpGet]
        public IActionResult Input()
        {
            return View(new AsciiInputModel { UserInput = "" }); // satisfies 'required'
        }

        [HttpPost]
        public IActionResult Input(AsciiInputModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Use Hell0_TDD.Core to render ASCII art
            ViewData["AsciiOutput"] = Hell0_TDD.Core.AsciiRenderer.RenderAscii(model.UserInput);
            return View(model);
        }
    }
}
