using System.Collections.Generic;
using System;

namespace Anagram.Models
{
    public class Word
    {
        private string _word;
        private static List<Word> _words = new List<Word> {};
        private static List<Word> _sortedWords = new List<Word> {};

        public Word(string word)
        {
          _word = word;
        }
        public static void SortList()
        {
          foreach(Word element in _words)
          {
            char[] toArray = element.GetWord().ToCharArray();
            Array.Sort(toArray);
            Word listItemArrayToString = new Word(String.Join("", toArray));
            _sortedWords.Add(listItemArrayToString);
          }
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
        public static List<Word> GetAll()
        {
          // for(int i=0; i<_words.Count; i++)
          // {
          // char[] newArray = _words[i].ToCharArray();
          // Array.Sort(newArray);
          // Word arrayItemToString = new Word(String.Join("", newArray));
          // _words[i] = arrayItemToString;
          // }
          return _words;

        }
        public static void ClearAll()
        {
          _words.Clear();
        }
        public static List<Word> GetAllSortedItems()
        {
          return _sortedWords;
        }
        public static void ClearAllSortedItems()
        {
          _sortedWords.Clear();
        }
    }
}
