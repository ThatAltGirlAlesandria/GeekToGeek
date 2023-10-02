using System.ComponentModel.DataAnnotations;

namespace G2GClient.ViewModels
{
  public class Login
  {
    [Required]
    [Display(Name = "User Name")]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
  }
}