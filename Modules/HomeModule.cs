using System;
using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ => {
        RepeatCounter newCount = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
        return View["result.cshtml", newCount];
      };
    }
  }
}
