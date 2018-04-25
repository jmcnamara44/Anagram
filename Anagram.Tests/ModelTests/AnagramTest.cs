using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest : IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
      Word.ClearAllSortedItems();
    }
    [TestMethod]
    public void ReturnWord_ReturnsWord_Word()
    {
      string testWord1 = "abc";
      Word test = new Word(testWord1);
      string testWord2 = "abc";
      Assert.AreEqual(testWord2, test.ReturnWord(test.GetWord()));
    }
    [TestMethod]
    public void ReturnWord_ReturnsWordSorted_WordSorted()
    {
      string testWord1 = "hide";
      Word test = new Word(testWord1);
      string testWord2 = "dehi";
      Assert.AreEqual(testWord2, test.ReturnWord(test.GetWord()));
    }
    [TestMethod]
    public void GetAll_ReturnsAllWords_WordsList()
    {
      string testString1 = "abc";
      string testString2 = "def";
      string testString3 = "ghi";
      Word newWord1 = new Word(testString1);
      newWord1.Save();
      Word newWord2 = new Word(testString2);
      newWord2.Save();
      Word newWord3 = new Word(testString3);
      newWord3.Save();
      List<Word> testList = new List<Word> { newWord1, newWord2, newWord3 };
      List<Word> result = Word.GetAll();
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void SortList_ReturnsAllWordsSorted_WordsListSorted()
    {
      string testString1 = "zebra";
      string testString2 = "bad";
      string testString3 = "aberz";
      string testString4 = "abd";
      Word newWord1 = new Word(testString1);
      newWord1.Save();
      Word newWord2 = new Word(testString2);
      newWord2.Save();
      Word newWord3 = new Word(testString3);
      Word newWord4 = new Word(testString4);
      List<Word> testList = new List<Word> { newWord3, newWord4 };
      Word.SortList();
      List<Word> result = Word.GetAllSortedItems();
      // foreach (Word word in result)
      // {
        // Console.WriteLine(testList.Count);
      // }
      // foreach (Word word in testList)
      // {
        // Console.WriteLine(result.Count);
      // }
      Assert.AreEqual(testList.Count, result.Count);
      Assert.AreEqual(testList[0].GetWord(), result[0].GetWord());
      Assert.AreEqual(testList[1].GetWord(), result[1].GetWord());
    }
  }
}
