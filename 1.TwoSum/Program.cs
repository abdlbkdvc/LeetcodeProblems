

public class Solution
{
    int[] array = new int[4] { 1, 2, 3, 4 };
    public int[] TwoSum(int[] nums, int target)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                sum = nums[i] + nums[j];
                if (sum == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }
}




