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
        Assert.IsTrue(anagram.IsAnagram("abc", "CAB"));
    }

    [TestMethod]
    public void TestMethod3()
    {
        Assert.IsTrue(anagram.IsAnagram("cinema", "iceman"));
    }

    [TestMethod]
    public void TestMethod4()
    {
        Assert.IsFalse(anagram.IsAnagram("", "aaaa"));
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.IsTrue(anagram.IsAnagram("SSE ca", "caE SS"));
    }
}