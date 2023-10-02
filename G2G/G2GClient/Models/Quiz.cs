using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using G2GClient.Models;
using G2GClient.ViewModels;

namespace G2GClient.Models;

public class Quiz
{
  public int QuizId { get; set; }
  public string Description { get; set; }
  public List<UserQuiz> UserQuizs { get; }

  public static List<Quiz> GetAll()
  {
    var apiCall = ApiHelper.GetAllQuizsAsync();
    var result = apiCall.Result;
  }

  public static Quiz GetDetails(int id)
  {
    var apiCall = ApiHelper.Get(id);
    var result = apiCall.Result;
  }

  public static void Post (Quiz quiz)
  {
    
  }

  public static void Put(Quiz quiz)
  {

  }

  public static void Delete(int id)
  {
    ApiHelper.Delete(id);
  }
}