using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using G2GClient.Models;
using G2GClient.ViewModels;

namespace G2GClient.Controllers;

public class UserController : Controller
{
  public async Task<IActionResult> Index()
  {
    ViewBag.UserName = HttpContext.Session.GetString("username");
    try
    {
      List<User> users = await User.GetAllAsync(token);
      return View(users);
    }
    catch(Exceptions e)
    {
      ViewBag.ErrorMessage = e.Message;
      return View();
    }

    public IActionResult Details(int id)
    {
      var user = User.GetDetails(id);
      return View(user);
    }

    public IActionResult UserProfile()
    {
      return View();
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(User user)
    {
      User.Post(user);
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var user = User.GetDetails(id);
      return View(user);
    }

    [HttpPost]
    public ActionResult Edit(User user)
    {
      User.Put(user);
      return RedirectToAction("Details", new { id = user.UserId });
    }

    public ActionResult Delete(int id)
    {
      var user = User.GetDetails(id);
      return View(user);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      User.Delete(id);
      return RedirectToAction("Index");
    }

    public ActionResult AddQuiz(int id)
    {
      List<Quiz> quizs = Quiz.GetAll();
      ViewData["allQuizs"] = quizs;
      var user = User.GetDetails(id);
      return View(user); 
    }

    [HttpPost]
    public ActionResult AddQuiz(User user, int[] quizId)
    {
      foreach (int item in quizId)
      {
        User.AddQuizToUser(user.UserId, item);
      }
      return RedirectToAction("Details", new { id = user.UserId });
    }

    [HttpPost]
    public ActionResult AddUpVote (int id, string vote)
    {
      User user = User.GetDetails(id);
      if (vote == "yes")
      {
        user.UpVote++;
      }
      else if (vote == "no")
      {
        user.UpVote--;
      }
      User.Put(user);
      return RedirectToAction("Index");
    }
  }
}