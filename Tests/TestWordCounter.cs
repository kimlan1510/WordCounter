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

    [Fact]
    public void Test2_SplitSentenceIntoWords_ReturnFalse()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter("hello", "hello world");
      string [] word = new string[]{"hello"};

      //Act
      string sentence = newCount.GetSentence();
      string[] wordArray = newCount.SplitSentence(sentence);

      //Assert
      Assert.Equal(word, wordArray);
    }

    [Fact]
    public void Test3_CountWord_ReturnFalse()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter("hello", "hello world");

      //Act
      string word = newCount.GetWord();
      string sentence = newCount.GetSentence();
      string[] wordArray = newCount.SplitSentence(sentence);
      int count = newCount.CountRepeats(word, wordArray);

      //Assert
      Assert.Equal(0, count);
    }
  }
}
