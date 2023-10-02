using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using G2GClient.Models;
using G2GClient.ViewModels;

namespace G2GClient.Controllers;

public class AccountController : Controller

{

  public ActionResult Index()
  {
    ViewBag.UserName = HttpContext.Session.GetString("username");
    return View();
  }

  public IActionResult Register()
  {
    return View();
  }

  [HttpPost]
  public async Task<ActionResult> Register(RegisterViewModel model)
  {
    if (!ModelState.IsValid)
    {
      return View(model);
    }
    await ApplicationUser.RegisterAsync(model);
    return RedirectToAction("Index");
  }

  public ActionResult Login()
  {
    return View();
  }

  [HttpPost]
  public async Task<ActionResult> Login(LoginViewModel model)
  {
    if (!ModelState.IsValid)
    {
      return View(model);
    }
    var tokenModel = await ApplicationUser.LogInAsync(model);
    HttpContext.Session.SetString("username", tokenModel.UserName);
    return RedirectToAction("Index");
  }

  [HttpPost]
  public async Task<ActionResult> LogOut()
  {
    await _signInManager.SignOutAsync();
    return RedirectToAction("Index");
  }

  [HttpPost]
  public ActionResult Delete()
  {
    return view();
  }
}