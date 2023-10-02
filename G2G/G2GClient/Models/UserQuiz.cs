using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using G2GClient.Models;
using G2GClient.ViewModels;

namespace G2GClient.Models;

public class UserQuiz
{
  public int UserQuizId { get; set; }
  public int UserId { get; set; }
  public User User { get; set; }
  public int QuizId { get; set; }
  public UserQuiz Quiz { get; set; }
}