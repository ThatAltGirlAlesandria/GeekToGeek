using System.ComponentModel.DataAnnotations;

namespace G2GClient.ViewModels
{
  public class Register
  {
    [Required]
    [Display(Name = "User Name")]
    public string UserName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Your password must contain at least eight characters, a capital letter, a lowercase letter, a number or a special character.")]
    public string Password { get; set; }

  [Required]
  [DataType(DataType.Password)]
  [Display(Name = "Confirm Password")]
  [Compare("Password", ErrorMessage =  "The Passwords you enter do not match. Please try again.")]
  public string ConfirmPassword { get; set; }
  }
}