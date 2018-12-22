using System;
using System.Collections.Generic;

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
        for (int i = initialString.Length - 1; i > 1; i--)
        {
          initialString = Permute(initialString, i);
          result.Add(initialString);
        }
      } while (startSequence != initialString);

      return result;
    }

    public static string Permute(string theString, int position)
    {
      //string backupChar = theString[position - 1].ToString();
      //string result = theString.Substring(0, theString.Length - position - 1);
      //result += backupChar + theString[position - 1];
      //return result;
      var tmp = theString.Split();
      string backup = tmp[position];
      string result = "";
      return result;
    }
  }
}