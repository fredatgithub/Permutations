using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;

namespace UnitTestPermutations
{
  [TestClass]
  public class UnitTestFindAllPermutations
  {
    [TestMethod]
    public void TestMethod_FindAllPermutations_123()
    {
      const string source = "123";
      var expected = new List<string> { "123", "132", "312", "321", "231", "213" };
      List<string> result = Program.FindAllPermutations(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.IsTrue(ListsAreEqualed(result, expected));
    }

    public static bool ListsAreEqualed(List<string> source, List<string> target)
    {
      bool result = true;
      if (source.Count != target.Count)
      {
        return false;
      }

      for (int i = 0; i < source.Count; i++)
      {
        if (source[i] != target[i])
        {
          result = false;
          break;
        }
      }

      return result;
    }
  }
}
