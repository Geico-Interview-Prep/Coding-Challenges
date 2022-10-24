using WordCount;

namespace WordCountTest;

[TestClass]
public class SolutionTest
{
    Solution solution = new Solution();

    [TestMethod]
    public void TestMethod1()
    {
        string sentence = "The big dog jumped high    over the lazy red fox  and the man with the  red hat sat high  in the chair and laughed";
        string ans = "and: 2\nhigh: 2\nred: 2\nthe: 5";
        Assert.AreEqual(ans, solution.WordCount(sentence));
    }

    [TestMethod]
    public void TestMethod2()
    {
        string sentence = "Big blue red   Orange biG small  Purple  black white  white Red red";
        string ans = "big: 2\nred: 3\nwhite: 2";
        Assert.AreEqual(ans, solution.WordCount(sentence));
    }

    [TestMethod]
    public void TestMethod3()
    {
        string sentence = "java javascript   python book book club pack backpack";
        string ans = "book: 2";
        Assert.AreEqual(ans, solution.WordCount(sentence));
    }
}