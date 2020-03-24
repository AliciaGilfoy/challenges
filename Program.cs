using System;
using test_cs.Models;

namespace test_cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      System.Console.WriteLine(Utils.doubleInteger(3));
      System.Console.WriteLine(Utils.doubleInteger(24));
      System.Console.WriteLine(Utils.doubleInteger(89));
      System.Console.WriteLine(Utils.isNumberEven(11));
      System.Console.WriteLine(Utils.isNumberEven(10));
      System.Console.WriteLine(Utils.getFileExtension("test.txt"));
      System.Console.WriteLine(Utils.getFileExtension("test.test.txt"));
      System.Console.WriteLine(Utils.longestString(new string[] { "hello", "world", "in", "pandemic" }));
      System.Console.WriteLine(Utils.arraySum(new int[] { 1, 3, 4, 5, 6, 9, 2, 35, 68 }));
    }
  }
}
