using Microsoft.AspNetCore.Identity;
using G2GClient.ViewModels;
using Microsoft.AspNetCore.Http;

namespace G2GClient.Models;

public class ApplicationUser : IdentityUser
{
  public async static Task RegisterAsync(Register newUser)
  {
    var g2gNewUser = NewUserConvert.SerializeObject(newUser);
    await ApiHelper.RegisterUserAsync(g2gNewUser);
  }

  public static Task<TokenModel> LoginAsync(Login user)
  {
    return ApiHelper.LoginUserAsync(user);
  }
}