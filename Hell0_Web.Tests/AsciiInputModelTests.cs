using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hell0_Web.Models;
using Xunit;

namespace Hell0_Web.Tests
{
    public class AsciiInputModelTests
    {
        private static List<ValidationResult> ValidateModel(AsciiInputModel model)
        {
            var context = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(model, context, results, true);
            return results;
        }

        [Fact]
        public void Should_Fail_When_UserInput_Is_NullOrEmpty()
        {
            var model = new AsciiInputModel { UserInput = "" };

            var results = ValidateModel(model);

            Assert.Contains(results, r => r.ErrorMessage == "Please enter some text.");
        }

        [Fact]
        public void Should_Fail_When_UserInput_Exceeds_MaxLength()
        {
            var model = new AsciiInputModel { UserInput = new string('a', AsciiInputModel.MaxLength + 1) };
            var results = ValidateModel(model);

            Assert.Contains(results, r => r.ErrorMessage == $"Input cannot exceed {AsciiInputModel.MaxLength} characters.");
        }

        [Fact]
        public void Should_Pass_When_UserInput_Is_Valid()
        {
            var model = new AsciiInputModel { UserInput = "Hello" };

            var results = ValidateModel(model);

            Assert.Empty(results);
        }
    }
}
