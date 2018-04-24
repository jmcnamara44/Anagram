using System.Collections.Generic;
using System;

namespace Anagram.Models
{
    public class Word
    {
        private string _word;
        private static List<Word> _words = new List<Word> {};

        public Word(string word)
        {
          _word = word;
        }
        public string ReturnWord(string word)
        {
          char[] array1 = word.ToCharArray();
          Array.Sort(array1);
          string arrayToString = String.Join("", array1);
          return arrayToString;
        }
        public string GetWord()
        {
          return _word;
        }
        public void Save()
        {
          _words.Add(this);
        }

    }
}
