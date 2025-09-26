using System.ComponentModel.DataAnnotations;

namespace Hell0_Web.Models
{
    public class AsciiInputModel
    {
        [Required(ErrorMessage = "Please enter some text.")]
        [StringLength(100, ErrorMessage = "Input cannot exceed 100 characters.")]
        public string UserInput { get; set; }

        // Optional: font selection for future stretch goal
        public string Font { get; set; } = "Standard";
    }
}
