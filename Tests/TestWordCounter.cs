using System;
using Xunit;

namespace WordCounter.Objects
{
  public class TestWord
  {
    [Fact]
    public void Test1_GetUserInput_ReturnTrue()
    {
      //Arrange
      string testWord = "hello";
      RepeatCounter newCount = new RepeatCounter("hello", "hello world");

      //Act
      string resultWord = newCount.GetWord();

      //Assert
      Assert.Equal(testWord, resultWord);
    }

    [Fact]
    public void Test2_SplitSentenceIntoWords_ReturnTrue()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter("hello", "hello world");
      string [] testString = new string[]{"hello", "world"};

      //Act
      string sentence = newCount.GetSentence();
      string[] resultString = newCount.SplitSentence(sentence);

      //Assert
      Assert.Equal(testString, resultString);
    }
    //
    // [Fact]
    // public void Test3_CountWord_ReturnFalse()
    // {
    //   //Arrange
    //   RepeatCounter newCount = new RepeatCounter("hello", "hello world");
    //
    //   //Act
    //   string word = newCount.GetWord();
    //   string sentence = newCount.GetSentence();
    //   string[] wordArray = newCount.SplitSentence(sentence);
    //   int count = newCount.CountRepeats(word, wordArray);
    //
    //   //Assert
    //   Assert.Equal(0, count);
    // }
  }
}
