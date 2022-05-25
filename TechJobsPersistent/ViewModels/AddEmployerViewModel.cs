using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Employer is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employer name must be between 3 to 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is equired")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Location must be between 3 to 100 characters")]
        public string Location { get; set; }

    }
}
