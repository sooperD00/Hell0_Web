using Hell0_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell0_Web.Tests
{
    internal class AsciiControllerTests
    {
        [Fact]
        public void Input_Get_ReturnsViewWithAsciiInputModel()
        {
            var controller = new AsciiController();

            var result = controller.Input();

            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsType<AsciiInputModel>(viewResult.Model);
        }

        [Fact]
        public void Post_Input_ReturnsAsciiOutput()
        {
            var controller = new AsciiController();
            var model = new AsciiInputModel { UserInput = "Test" };

            var result = controller.Input(model);

            var viewResult = Assert.IsType<ViewResult>(result);
            var output = viewResult.ViewData["AsciiOutput"] as string;
            Assert.Contains("T", output); // basic sanity check
        }
    }
}
