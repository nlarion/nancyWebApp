using Nancy;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/hello"] = _ => "Hello friend!";
      Get["/goodbye"] = _ => "Goodbye friend!";
      Get["/"] = _ => View["hello.html"];
      Get["/favorite_photos"] = _ => View["favorite_photos.html"];
    }
  }
}