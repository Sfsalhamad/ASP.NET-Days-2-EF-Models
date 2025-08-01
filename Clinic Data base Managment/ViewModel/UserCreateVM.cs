using Clinic_Data_base_Managment.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Data_base_Managment.ViewModels
{
    public class UserCreateVM
    {
        [Required]
        [EmailAddress] public string Email { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)] public string Password { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm Password")] public string ConfirmPassword { get; set; } = null!;
        [Required]
        [EnumDataType(typeof(AppRoles))] public string Role { get; set; } = null!;
    }
}
