using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            Word.ClearAll();
            Word.ClearAllSortedItems();
            Word.ClearAllMatches();
            return View();
        }
        [HttpPost("/check-anagrams")]
        public ActionResult Results()
        {
          Word.ClearAll();
          Word.ClearAllSortedItems();
          Word.ClearAllMatches();

            Dictionary<string, object> model = new Dictionary<string, object> {};
            Word newWord = new Word(Request.Form["single-word"]);
            Word newWord1 = new Word(Request.Form["first-word"]);
            newWord1.Save();
            Word newWord2 = new Word(Request.Form["second-word"]);
            newWord2.Save();
            Word newWord3 = new Word(Request.Form["third-word"]);
            newWord3.Save(); //saves words to a list unsorted
            Word.SortList(); //takes the users inputted list, sorts each element and adds them to a sortedlist
            Word sortedWord = new Word(newWord.ReturnWord(newWord.GetWord())); //takes the users first word and sorts it and saves it as a variable
            Word.CompareWords(sortedWord.GetWord()); //compares the sorted word that the user entered with words in the sorted list from
            List<Word> matchedList = Word.GetAllMatches();
            model.Add("word", newWord);
            model.Add("list", matchedList);
            return View(model);
        }
    }
}
