
public class Solution
{
    public bool IsPalindrome(int x)
    {
        char[] inputToChar = x.ToString().ToCharArray();
        //char[] reverseInputChar = new char[inputToChar.Length];
        //reverseInputChar = inputToChar;
        int reverseCharIndexCount = 0;

        for (int i = inputToChar.Length - 1; i >= 0; i--)
        {
            if (inputToChar[i] == inputToChar[reverseCharIndexCount])
            {
                reverseCharIndexCount++;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}