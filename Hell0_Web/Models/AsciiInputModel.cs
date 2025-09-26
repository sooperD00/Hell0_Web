using System.ComponentModel.DataAnnotations;

namespace Hell0_Web.Models
{
    public class AsciiInputModel
    {
        private const int MaxLength = 200;

        [Required(ErrorMessage = "Please enter some text.")]
        //[StringLength(MaxLength, ErrorMessage = "Input cannot exceed 200 characters.")]
        [StringLength(MaxLength, ErrorMessage = $"Input cannot exceed {MaxLength} characters.")]
        //[StringLength(MaxLength, ErrorMessage = $"Input cannot exceed {MaxLength} characters.")]
        //[StringLength(MaxLength, ErrorMessage = "Input cannot exceed " + MaxLength + " characters.")]
        //[StringLength(MaxLength, ErrorMessage = "Input cannot exceed " + NameOf(MaxLength) + " characters.")]
        public required string UserInput { get; set; }

        // Optional: font selection for future stretch goal
        public string Font { get; set; } = "Standard";
    }
}
