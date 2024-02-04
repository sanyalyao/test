using System.Linq;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int>() { 1,2,3};
            var list2 = new List<int>() { 1,3,2};

             Console.WriteLine(Enumerable.SequenceEqual(list2., list1));
        }
    }
}