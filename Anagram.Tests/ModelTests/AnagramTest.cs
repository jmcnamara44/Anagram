
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
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
  }
}
