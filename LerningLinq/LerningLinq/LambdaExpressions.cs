using LerningLinq.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LerningLinq
{
    public static class LambdaExpressions
    {
        //// A lambda expression that will return the next number after the provided integer
        public static Func<int, int> GetNextNumber = num => num + 1;
        //Using Linq return only the strings that have pattern in them and order the list alphabetically.
        public static IEnumerable<string> FilterAndSortV1(IEnumerable<string> inValues, string pattern)
        {
            return from value in inValues
                   where value.Contains(pattern)
                   orderby value
                   select value;
        }
        public static IEnumerable<string> FilterAndSortV2(IEnumerable<string> inValues, string pattern)
        {
            return inValues.Where(x => x.Contains(pattern)).OrderBy(x => x);
        }
        // Return the first word with just one letter in it, out of a sequence of words.
        // There will always be at least one.
        public static string GetFirstSingleLetterWord(IEnumerable<string> words)
        {
            return words.Where(x => x.Length == 1).First();
        }

        // Return the last word that contains the substring "her" in it. There will always be at least one.
        public static string GetLastWordWithHerInIt(IEnumerable<string> words)
        {
            return words.Where(x => x.Contains("her")).Last();
        }

        // Return the fifth word in the sequence, if there is one. If there are fewer than 5 words, then return null.
        public static string GetFifthWordIfItExists(IEnumerable<string> words)
        {
            return words.ElementAtOrDefault(4);
        }

        // Return the last word in the sequence. If there are no words in the sequence, return null.
        public static string GetLastWordIfAny(IEnumerable<string> words)
        {
            return words.LastOrDefault();
        }

        // Return the 3rd, 4th, and 5th items of the provided sequence.
        public static IEnumerable<string> GetThirdFourthFifthItems(
            IEnumerable<string> words)
        {
            return words.Skip(2).Take(3);
        }
        // Return all words in the sequence between "start" (inclusive) and "end" (non-inclusive)
        public static IEnumerable<string> GetStartThroughEnd(IEnumerable<string> words, string startWord, string endWord)
        {
            return words.SkipWhile(theStr => !theStr.Contains(startWord)).TakeWhile(theStr => !theStr.Contains(endWord));
        }
        public static IEnumerable<string> GetDistinctShortWords(IEnumerable<string> words, int count)
        {
            return words.Where(x => x.Length > count).Distinct();
        }
        // Return the provided list of names, ordered by Last, in descending order.
        public static IEnumerable<IName> SortNames(IEnumerable<IName> names)
        {
            return names.OrderByDescending(x => x.Last);
        }
        // Return the provided list of names, ordered by Last, then First, then Middle
        public static IEnumerable<IName> SortNamesV2(IEnumerable<IName> names)
        {
            return names.OrderBy(x => x.Last).ThenBy(x => x.First).ThenBy(x => x.Middle);
        }
        // Return the number of strings in the provided sequence that begin with  the provided startString.
        public static int NumberThatStartWith(IEnumerable<string> words, string startString)
        {
            return words.Count(x => x.StartsWith(startString));
        }
        // Return the length of the shortest word
        public static int LengthOfShortestWord(IEnumerable<string> words)
        {
            // Uncomment:
            var sdf=  words.Min(x=>x.Length);
            return 0;
        }
        //TODO - use LINQ
        // Return the total number of characters in all words in the source sequence
        public static int TotalCharactersInSequence(IEnumerable<string> words)
        {
            var counter = 0;
           foreach(string word in words)
            {
                counter += word.Length;
            }
            return counter;
        }

        // Return display strings in the form of "<Last>, <First>" for each provided name
        public static IEnumerable<string> DisplayStringsForNames(IEnumerable<IName> names)
        {
            return names.Select(x => $"{x.Last}, {x.First}");
        }

        // Given a sequence of words, get rid of any that don't have the character 'e' in them,
        // then sort the remaining words alphabetically, then return the following phrase using
        // only the final word in the resulting sequence: -> "The last word is <word>"
        // If there are no words with the character 'e' in them, then return null.
        // TRY to do it all using only LINQ statements. No loops or if statements.
        public static string GetTheLastWord(IEnumerable<string> words)
        {
            return words.Where(x => x.Contains("e")).OrderBy(x => x).Select(c => $"The last word is {c}").LastOrDefault();
        }
    }
}