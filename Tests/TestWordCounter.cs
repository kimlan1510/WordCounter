using System;
using Xunit;

namespace WordCounter.Objects
{
  public class TestWord
  {
    [Fact]
    public void Test1_GetUserInput_ReturnFalse()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter("hello", "hello world");

      //Act
      string word = newCount.GetWord();
      string sentence = newCount.GetSentence();

      //Assert
      Assert.Equal(word, sentence);
    }
  }
}
