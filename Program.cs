using System;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] words = str.Split(' ');
            Array.Sort(words);
            string s = string.Join(" ", words);
            Console.WriteLine(s);
        }
    }
}