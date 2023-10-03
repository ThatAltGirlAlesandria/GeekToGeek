using System.ComponentModel.DataAnnotations;

namespace G2GApi.Auth;

public class LogIn
{
  #nullable enable
  [Required(ErrorMessage = "You must enter a username.")]
  public string Username { get; set; }

  [Required(ErrorMessage = "You must enter the password")]
  public string Password { get; set; }
}