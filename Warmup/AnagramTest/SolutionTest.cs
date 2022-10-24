using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace AnagramTest;

[TestClass]
public class SolutionTest
{
    Solution anagram = new Solution();

    [TestMethod]
    public void TestMethod1()
    {
        Assert.IsFalse(anagram.IsAnagram("abc", "bcad"));
    }

    [TestMethod]
    public void TestMethod2()
    {
        Assert.IsTrue(anagram.IsAnagram("abc", "cab"));
    }
}