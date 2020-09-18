using System;
using System.Collections.Generic;

namespace LerningLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LambdaExpressions.GetNextNumber(6));
            var v1 = LambdaExpressions.FilterAndSortV1(new List<string> { "foo", "bar", "goo", "onion"}, "oo");
            var v2 = LambdaExpressions.FilterAndSortV2(new List<string> { "foo", "bar", "goo", "onion" }, "oo");
            var v3 = LambdaExpressions.GetStartThroughEnd(new List<string> { "One", "start", "more", "end", "thing", "throught" }, "start", "end");
            var v4 = LambdaExpressions.NumberThatStartWith(new List<string> { "One", "start", "more", "end", "thing", "throught" }, "th");
            var v5 = LambdaExpressions.LengthOfShortestWord(new List<string> { "This","is", "the", "first","test" });
            var v6 = LambdaExpressions.TotalCharactersInSequence(new List<string> { "This", "is", "the", "first", "test" });
            Console.ReadLine();
        }
    }
}
