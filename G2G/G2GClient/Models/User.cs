using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using G2GClient.Models;
using G2GClient.ViewModels;

namespace G2GClient.Models;

public class User
{
  public int Age { get; set; }
  public int UserId { get; set; }
  public int UpVote { get; set; }
  public string Name { get; set; }
  public string Location { get; set; }
  public string ProfilePicture { get; set; }
  public List<UserQuiz> UserQuiz { get; set; }
}

public async static Task<List<User>> GetAllAsync(string token)
{
  var userList = await ApiHelper.GetAllUserAsync(token);
  return userList;
}

public static User GetDetails(int id)
{
  var apiCall = ApiHelper.GetDetailsAsync(id);
  var result = apiCall.result;

  return User;
}

public static void Post(User user)
{
  var 
}

public static void Put(User user)
{
  var
}

public static void Delete(int id)
{
  ApiHelper.DeleteAsync(id);
}

public static User AddQuizToUser(int userId, int quizId)
{
  var apiCall= ApiHelper.AddQuizToUserAsync(userId, quizId)
  var result = apiCall.Result;
}