using System.ComponentModel.DataAnnotations;

namespace Hell0_Web.Models
{
    public class AsciiInputModel
    {
        // Public so tests can reference it dynamically
        public const int MaxLength = 200;

        [Required(ErrorMessage = "Please enter some text.")]
        // Built-in attribute: {1} is filled in with the max length
        [MaxLength(MaxLength, ErrorMessage = "Input cannot exceed {1} characters.")]
        public required string UserInput { get; set; }
    }
}
