public class Solution
{

    public int RomanNumberConvertToInt(char c)
    {
        int value = 0;
        if (c == 'I')
            value = 1;
        else if (c == 'V')
            value = 5;
        else if (c == 'X')
            value = 10;
        else if (c == 'L')
            value = 50;
        else if (c == 'C')
            value = 100;
        else if (c == 'D')
            value = 500;
        else if (c == 'M')
            value = 1000;
        return value;
    }
    public bool isValidSubstraction(char currentVal, char previousVal)
    {

        if (currentVal == 'I' && previousVal == 'V' || previousVal == 'X')
        {
            return true;
        }
        else if (currentVal == 'X' && previousVal == 'L' || previousVal == 'C')
        {
            return true;
        }
        else if (currentVal == 'C' && previousVal == 'D' || previousVal == 'M')
        {
            return true;
        }

        return false;
    }
    public int RomanToInt(string s)
    {
        int currentValue = 0;
        int previousValue = 0;
        int sameValueCounter = 0;
        int sum = 0;
        for (int i = s.ToCharArray().Length - 1; i >= 0; i--)
        {

            currentValue = RomanNumberConvertToInt(s[i]);


            if (currentValue > previousValue)
            {

                sum += currentValue;
                previousValue = currentValue;
            }
            else if (currentValue < previousValue)
            {
                if (isValidSubstraction(s[i], s[i + 1]))
                {
                    if (currentValue == 1)
                        sum -= currentValue;
                    previousValue = currentValue;
                }

            }
            else if (currentValue == previousValue)
            {
                sameValueCounter++;
                if (sameValueCounter != 3)
                {
                    sum += currentValue;
                    previousValue = currentValue;
                }
                else
                {
                    sameValueCounter = 0;
                }
            }
        }
        return sum;
    }
}