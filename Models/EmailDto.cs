using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class EmailDto
    {
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string? Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a subject for the email")]
        public string? Subject { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a message for the email")]
        public string? Message { get; set; }
    }
}
