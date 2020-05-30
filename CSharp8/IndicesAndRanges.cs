using System;

namespace CSharp8
{
    public static class IndicesAndRanges
    {
        public static void index()
        {
            string[] words = new string[]{
                                                        // index from start    index from end
                                            "The",      // 0                   ^9
                                            "quick",    // 1                   ^8
                                            "brown",    // 2                   ^7
                                            "fox",      // 3                   ^6
                                            "jumped",   // 4                   ^5
                                            "over",     // 5                   ^4
                                            "the",      // 6                   ^3
                                            "lazy",     // 7                   ^2
                                            "dog"       // 8                   ^1
                                              };
            //foreach (var item in words[1..^0]) // from postion one to dog 
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in words[..^0]) // from postion one to dog 
            //{
            //    Console.WriteLine(item);
            //}
            //   Console.WriteLine(words[^1]);
            //foreach(var item in words[^2..^0]) // from postion 7 to the end 
            //{
            //    Console.WriteLine(item);
            //}
            //var allWords = words[..]; // contains "The" through "dog".
            //var firstPhrase = words[..4]; // contains "The" through "fox"
            //var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
            Range rang = 1..4;
        }
    }
}
