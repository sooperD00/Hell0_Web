using Hell0_Web.Models;
using Hell0_Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Hell0_Web.Tests
{
    public class AsciiControllerTests
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

        [Fact]
        public void Post_Input_InvalidModel_ReturnsViewWithModelErrors()
        {
            var controller = new AsciiController();

            // Create a model with empty input
            var model = new AsciiInputModel { UserInput = "" };

            // Simulate invalid model state (e.g., Required failed)
            controller.ModelState.AddModelError("UserInput", "Required");

            var result = controller.Input(model);

            var viewResult = Assert.IsType<ViewResult>(result);
            // Ensure the same model is passed back to the view
            Assert.Equal(model, viewResult.Model);
            // Ensure ModelState contains errors
            Assert.False(controller.ModelState.IsValid);
            Assert.Contains(controller.ModelState, kvp => kvp.Key == "UserInput");
        }

        [Fact]
        public void Post_Input_EmptyUserInput_ReturnsViewWithValidationError()
        {
            var controller = new AsciiController();
            var model = new AsciiInputModel { UserInput = "" };

            // Let the controller handle validation automatically
            controller.TryValidateModel(model);

            var result = controller.Input(model);

            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(model, viewResult.Model);
            Assert.False(controller.ModelState.IsValid);
            Assert.Contains(controller.ModelState, kvp => kvp.Key == "UserInput");
        }


        // Using Theory to test multiple invalid inputs
        //check if this is the same as above test
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("    ")] // optional: whitespace only
        public void Post_Input_InvalidUserInput_ReturnsViewWithValidationError(string invalidInput)
        {
            // Arrange
            var controller = new AsciiController();
            var model = new AsciiInputModel { UserInput = invalidInput };

            // Trigger automatic model validation
            controller.TryValidateModel(model);

            // Act
            var result = controller.Input(model);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(model, viewResult.Model);
            Assert.False(controller.ModelState.IsValid);
            Assert.Contains(controller.ModelState, kvp => kvp.Key == "UserInput");
        }

        [Fact]
        public void Post_Input_RendersAsciiArt_UsingFiggle()
        {
            // Arrange
            var controller = new AsciiController();
            var model = new AsciiInputModel { UserInput = "Hi" };

            // Act
            var result = controller.Input(model);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var output = viewResult.ViewData["AsciiOutput"] as string;

            // Figgle output contains multiple lines and special characters
            Assert.NotNull(output);
            Assert.Contains("\n", output); // ASCII art is multi-line
            Assert.True(output.Length > "Hi".Length); // Should be bigger than input
        }

    }
}
