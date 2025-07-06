public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string[] example = new string[] { "flower", "flow", "flight" };

        strs = example;
        string commonPrefix = "";
        string shortestString = "";
        if (strs.Length == 0)
        {
            return null;
        }
        else if (strs.Length == 1)
        {
            return strs[0];
        }
        else if (strs.Length >= 2)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                bool isShorter = strs[i].Length < strs[i + 1].Length;
                if (i + 1 <= strs.Length - 1)
                {
                    if (isShorter)
                    {
                        
                    }
                }

            }



        }

    }
}
