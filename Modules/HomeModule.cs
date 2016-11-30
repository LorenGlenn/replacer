using Nancy;
using System;

namespace FindReplace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];
    }
  }
}
