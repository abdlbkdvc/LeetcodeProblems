

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int sum = 0;

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
            }
            else if (digits[i] != 9)
            {
                digits[i]++;
                return digits;
            }
        }
        int[] newArray = new int[digits.Length + 1];
        newArray[0] = 1;
        return newArray;
    }
}