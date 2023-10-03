using System.ComponentModel.DataAnnotations;

namespace G2GApi.Auth;

public class Register
{
  #nullable enable
  [Required(ErrorMessage = "You must enter a username.")]
  public string Username { get; set; }

  [EmailAddress]
  [Required(ErrorMessage = "You must enter a valid email address.")]
  public string Email { get; set; }

  [Required(ErrorMessage = "You must enter a password.")]
  public string Password { get; set; }
}