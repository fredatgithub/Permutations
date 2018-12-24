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

    [TestMethod]
    public void TestMethod_FindAllPermutations_1234()
    {
      const string source = "1234";
      var expected = new List<string>
      {
        "1234", "1243", "1423", "4123", "4132", "4312", "3412",
        "3421", "3241", "2341", "2314", "2134"
      };
      List<string> result = Program.FindAllPermutations(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.IsTrue(ListsAreEqualed(result, expected));
    }
    
    [TestMethod]
    public void TestMethod_FindAllPermutations_12345()
    {
      const string source = "12345";
      var expected = new List<string>
      {
        "12345", "12354", "12534", "15234", "51234", 
        "51243", "51423", "54123", "45123",
        "45132", "45312", "43512", "34512",
        "34521", "34251", "32451", "23451",
        "23415", "23145", "21345"
      };
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
