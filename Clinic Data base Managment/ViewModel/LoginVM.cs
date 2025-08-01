using System.ComponentModel.DataAnnotations;

namespace Clinic_Data_base_Managment.ViewModel
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
