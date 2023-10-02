using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using G2GClient.Models;
using G2GClient.ViewModels;

namespace G2GClient.Models;

public class ApplicationUser : 
{
  public async static Task RegisterAsync(RegisterViewModel newUser)
  {
    var
    await
  }

  public static Task<TokenModel> LoginAsync(LoginViewModel user)
  {
    return ApiHelper.LoginUserAsync(user);
  }
}