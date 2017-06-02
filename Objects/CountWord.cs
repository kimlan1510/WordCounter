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
  }
}
