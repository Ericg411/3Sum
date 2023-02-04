namespace _3Sum;
public class ThreeSum
{
    public IList<IList<int>> ThreeSumFunction(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        int i = 0;
        int target;
        while (i < nums.Length - 2)
        {
            target = nums[i] * -1;
            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                int sum = nums[j] + nums[k];

                if (sum < target)
                {
                    j++;
                }
                else if (sum > target)
                {
                    k--;
                }
                else if (sum == target)
                {
                    List<int> list = new List<int>() { nums[i], nums[j], nums[k] };
                    result.Add(list);
                    while (j < k && nums[j] == list[1])
                    {
                        j++;
                    }
                    while (j < k && nums[k] == list[2])
                    {
                        k--;
                    }
                }
            }
            int currentI = nums[i];
            while (i < nums.Length - 2 && nums[i] == currentI)
            {
                i++;
            }
        }
        return result;
    }

}
