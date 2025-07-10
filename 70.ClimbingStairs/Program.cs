


public class Solution
{
    public int ClimbStairs(int n)
    {
        int[] array = new int[n];
        int returnValue = 0;

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                array[0] = 1;
                returnValue = array[0];
            }
            else if (i == 1)
            {
                array[i] = array[0] + i;
                returnValue = array[i];
            }
            else
            {
                array[i] = array[i - 1] + array[i - 2];
                returnValue = array[i];
            }

        }
        return returnValue;
    }
}