using Microsoft.VisualStudio.TestTools.UnitTesting;
using Permutations;

namespace UnitTestPermutations
{
  [TestClass]
  public class UnitTestPermute
  {
    [TestMethod]
    public void TestMethod_Permute_123()
    {
      const string source1 = "123";
      const int source2 = 3;
      const string expected = "132";
      string result = Program.Permute(source1, source2);
      Assert.AreEqual(result, expected);
    }

  }
}
