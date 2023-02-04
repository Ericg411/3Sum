namespace _3Sum.Tests;

[TestClass]
public class UnitTest1
{
    private readonly ThreeSum _3Sum;

    public UnitTest1()
    {
        _3Sum = new ThreeSum();
    }

    [TestMethod]
    public void TestMethod1()
    {
        bool equal = true;

        int[] nums = { -1, 0, 1, 2, -1, -4 };

        IList<IList<int>> answer = new List<IList<int>>();
        IList<int> ints1 = new List<int>() { -1, -1, 2 };
        IList<int> ints2 = new List<int>() { -1, 0, 1 };
        answer.Add(ints1);
        answer.Add(ints2);

        IList<IList<int>> result = _3Sum.ThreeSumFunction(nums);

        for (int i = 0; i < answer.Count; i++)
        {
            for (int j = 0; j < answer[0].Count; j++)
            {
                Console.WriteLine($"Answer: {answer[i][j]}, Result: {result[i][j]}");
                if (answer[i][j] != result[i][j])
                {
                    equal = false;
                }
            }
        }
        Assert.IsTrue(equal);
    }

    [TestMethod]
    public void TestMethod2()
    {
        bool equal = true;

        int[] nums = { 0, 1, 1 };

        IList<IList<int>> answer = new List<IList<int>>();

        IList<IList<int>> result = _3Sum.ThreeSumFunction(nums);

        for (int i = 0; i < answer.Count; i++)
        {
            for (int j = 0; j < answer[0].Count; j++)
            {
                Console.WriteLine($"Answer: {answer[i][j]}, Result: {result[i][j]}");
                if (answer[i][j] != result[i][j])
                {
                    equal = false;
                }
            }
        }

        Assert.IsTrue(equal);
    }
    [TestMethod]
    public void TestMethod3()
    {
        bool equal = true;

        int[] nums = { 0, 0, 0 };

        IList<IList<int>> answer = new List<IList<int>>();
        IList<int> ints1 = new List<int>() { 0, 0, 0 };
        answer.Add(ints1);

        IList<IList<int>> result = _3Sum.ThreeSumFunction(nums);

        for (int i = 0; i < answer.Count; i++)
        {
            for (int j = 0; j < answer[0].Count; j++)
            {
                Console.WriteLine($"Answer: {answer[i][j]}, Result: {result[i][j]}");
                if (answer[i][j] != result[i][j])
                {
                    equal = false;
                }
            }
        }
        Assert.IsTrue(equal);
    }
}