using Xunit;
using System;
using FindReplace.Objects;

namespace FindReplaceTests
{
  public class ReplacerTests
  {
    [Theory]
    [InlineData("dog", "dog", "cat", "cat")]
    [InlineData("the dog barked", "dog", "cat", "the cat barked")]
    [InlineData("the dog barked", "bark", "meow", "the dog meowed")]
    [InlineData("the dog barked", "dog barked", "cat meowed", "the cat meowed")]
    [InlineData("tHe DOg baRkeD", "dOg", "CAt", "the cat barked")]
    public void ReplacerTheory(string inputString, string stringToReplace, string replacementString, string expectedResult)
    {
      Replacer testReplacer = new Replacer(inputString, stringToReplace, replacementString);
      string testResult = testReplacer.FindReplace();
      Assert.Equal(expectedResult, testResult);
    }
  }
}
