using System.ComponentModel.DataAnnotations;

namespace MVCPersonalSite.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "* Name is Required")] 
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "* An Emal is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "* A Subject is Required")]
        public string Subject { get; set; } = null!;
        [Required(ErrorMessage = "* A Message is Required")]
        [DataType(DataType.MultilineText)] 
        public string Message { get; set; } = null!;
    }
}
