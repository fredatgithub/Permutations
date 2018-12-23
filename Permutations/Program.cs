using System;
using System.Collections.Generic;
using System.Text;

namespace Permutations
{
  public class Program
  {
    static void Main()
    {
      string initialString = "123";
      List<string> result = FindAllPermutations(initialString);
      
      foreach (string item in result)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }

    public static List<string> FindAllPermutations(string initialString)
    {
      List<string> result = new List<string> { initialString };
      string startSequence = initialString;
      do
      {
        for (int i = initialString.Length; i > 1; i--)
        {
          initialString = Permute(initialString, i);
          result.Add(initialString);
        }
      } while (startSequence != initialString);
      result.RemoveAt(result.Count - 1);
      return result;
    }

    public static string Permute(string theString, int position)
    {
      char[] letters = new char[theString.Length];
      for (int i = 0; i < theString.Length; i++)
      {
        letters[i] = theString[i];
      }

      char backup = letters[position - 2];
      letters[position - 2] = letters[position - 1];
      letters[position - 1] = backup;
      StringBuilder result = new StringBuilder();
      for (int i = 0; i < letters.Length; i++)
      {
        result.Append(letters[i]);
      }

      var test = result.ToString();
      return result.ToString();
    }
  }
}