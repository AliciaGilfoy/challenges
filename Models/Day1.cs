using System.ComponentModel.DataAnnotations;

namespace test_cs.Models
{
  static class Utils
  {
    public static int doubleInteger(int num)
    {
      int newNum = num * 2;
      return newNum;
    }

    public static bool isNumberEven(int num)
    {
      if (num % 2 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static string getFileExtension(string str)
    {

      string[] words = str.Split(".");
      if (words.Length > 1)
      {
        return words[words.Length - 1];
      }
      else
      {
        return null;
      }
    }

    public static string longestString(string[] arr)
    {
      string longestWord = arr[0];
      for (int i = 1; i < arr.Length; i++)
      {
        string word = arr[i];
        if (word.Length > longestWord.Length)
        {
          longestWord = word;
        }
        else
        {
          i++;
        }
      }
      return longestWord;
    }

    public static int arraySum(int[] arr)
    {
      int total = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        total += arr[i];
      }
      return total;
    }
  }
}
