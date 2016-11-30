using Nancy;
using System;
using FindReplace.Objects;

namespace FindReplace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];

      Post["/replace"] =_=> {
        string inputString = Request.Form["newString"];
        string stringToReplace = Request.Form["newToReplace"];
        string replacementString = Request.Form["newReplacer"];
        Replacer newReplacer = new Replacer(inputString, stringToReplace, replacementString);
        string finalResult = newReplacer.FindReplace();
        return View["index.cshtml", finalResult];
      };
    }
  }
}
