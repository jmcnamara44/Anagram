using System.Collections.Generic;
using System.IO;
using System;

namespace Anagram.Models
{
    public class Word
    {
        private string _word;
        private static List<Word> _words = new List<Word> {};
        private static List<Word> _sortedWords = new List<Word> {};
        private static List<Word> _matches = new List<Word> {};

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
            _sortedWords.Add(listItemArrayToString);  //the SortList method will take the Word objects saved to the _words list, sort each of them into alphabetical order without changing their index positions and add them to the _sortedWords list
          }
        }
        public static void CompareWords(string word)
        {
          //in here should be where we compare the single word with each of the list of words the user has entered
          for(int i = 0; i<_sortedWords.Count; i++)
          {
            if (_sortedWords[i].GetWord() == word)
            {
              _matches.Add(_words[i]);
            }
          }
        }
        public string ReturnWord(string word)
        {
          char[] array1 = word.ToCharArray();
          Array.Sort(array1);
          string arrayToString = String.Join("", array1);
          return arrayToString;  //the ReturnWord method will take the users inputted word and resort the letters into alphabetical order
        }
        public string GetWord()
        {
          return _word;
        }
        public void SetWord(string newWord)
        {
          _word = newWord;
        }
        public void Save()
        {
          _words.Add(this);
        }
        public static List<Word> GetAll()
        {
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
        public static List<Word> GetAllMatches()
        {
          return _matches;
        }
        public static void ClearAllMatches()
        {
          _matches.Clear();
        }
    }
}
