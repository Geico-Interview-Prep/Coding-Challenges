using Pattern;

namespace PatternTest;

[TestClass]
public class SolutionTest
{
    Solution solution = new Solution();

    [TestMethod]
    public void TestMethod1()
    {
        Assert.IsTrue(solution.IsPattern("abba", "dog cat cat dog"));
    }

    [TestMethod]
    public void TestMethod2()
    {
        Assert.IsFalse(solution.IsPattern("abba", "dog cat cat fish"));
    }

    [TestMethod]
    public void TestMethod3()
    {
        Assert.IsFalse(solution.IsPattern("aaaa", "dog cat cat dog"));
    }

    [TestMethod]
    public void TestMethod4()
    {
        Assert.IsFalse(solution.IsPattern("abba", "dog dog dog dog"));
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.IsFalse(solution.IsPattern("aaa", "aa aa aa aa"));
    }

    [TestMethod]
    public void TestMethod6()
    {
        Assert.IsTrue(solution.IsPattern("deadbeef", "d e a d b e e f"));
    }
}