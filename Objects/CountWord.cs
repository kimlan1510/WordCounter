using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;

    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    // method to split a sentence into individual words.
    public string[] SplitSentence(string sentence)
    {
      string[] wordArray = sentence.Split(' ');
      return wordArray;
    }
    // method to count the number of times a word appears in a sentence.
    public int CountRepeats(string searchedWord, string[] wordArray)
    {
      int count = 0;
      foreach(string word in wordArray )
      {
        if(word == searchedWord)
        {
          count += 1;
        }
      }
      return count;
    }
  }
}
