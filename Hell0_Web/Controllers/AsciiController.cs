using Hell0_Web.Models;
using Microsoft.AspNetCore.Mvc;

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

        // POST: /Ascii/Input
       /*[HttpPost]
        public IActionResult Input(AsciiInputModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // For now, just return the model to the same view
            return View(model);
        }*/

        [HttpPost]
        public IActionResult Input(AsciiInputModel model)
        {
            ViewData["AsciiOutput"] = model.UserInput;
            return View(model);
        }
    }
}
