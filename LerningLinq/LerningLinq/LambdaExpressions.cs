using System;

namespace LerningLinq
{
    public static class LambdaExpressions
    {
        //// A lambda expression that will return the next number after the provided integer
        public static Func<int, int> GetNextNumber = num => num+1;
    }
}
