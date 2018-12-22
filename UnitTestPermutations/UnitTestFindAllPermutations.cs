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
      Assert.IsTrue(DictionariesAreEqualed(result, expected));
    }

    public static bool DictionariesAreEqualed(List<string> source, List<string> target)
    {
      if (source.Count != target.Count)
      {
        return false;
      }

      return source != target ? false : true;
    }
  }
}
