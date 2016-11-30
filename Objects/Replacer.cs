using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FindReplace.Objects
{
  public class Replacer
  {
    private string _inputString;
    private string _stringToReplace;
    private string _replacementString;

    public Replacer(string newInputString, string newStringToReplace, string newReplacementString)
    {
      _inputString = newInputString.ToLower();
      _stringToReplace = newStringToReplace.ToLower();
      _replacementString = newReplacementString.ToLower();
    }

    public string FindReplace()
    {
      Regex regToReplace = new Regex(_stringToReplace);
      string outputString = regToReplace.Replace(_inputString, _replacementString);
      return outputString;
    }
  }
}
