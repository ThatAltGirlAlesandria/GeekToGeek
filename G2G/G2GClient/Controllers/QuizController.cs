using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using G2GClient.Models;
using G2GClient.ViewModels;

namespace G2GClient.Controllers;

public class QuizController : Controller
{
  public IActionResult Index()
  {
    List<Quiz> quizs = Quiz.GetAll();

    return View(quizs);
  }

  public IActionResult Details(int id)
  {
    var quiz = Quiz.GetDetails(id);

    return View(quiz);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Quiz quiz)
  {
    Quiz.Post(quiz);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    Quiz quiz = Quiz.GetDetails(id);
    return View(quiz);
  }

  [HttpPost]
  public ActionResult Edit(Quiz quiz)
  {
    Quiz.Put(quiz);
    return RedirectToAction("Details", new { id = quiz.QuizId });
  }

  public ActionResult Delete (int id)
  {
    Quiz quiz = Quiz.GetDetails(id);
    return View(quiz);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Quiz.Delete(id);
    return RedirectToAction("Index");
  }
}