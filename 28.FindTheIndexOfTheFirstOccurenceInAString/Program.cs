using System;

//public class Solution
//{
//    public int StrStr(string haystack, string needle)
//    {
//        char[] checkedArray = new char[needle.Length];
//        char[] hayStackChars = haystack.ToCharArray();
//        char[] needleChars = needle.ToCharArray();
//        int indexCount = 0;
//        int counter = 0;

//        if (needle == null)
//        {
//            return -1;
//        }
//        if (needle == " ")
//        {
//            return 0;
//        }

//        for (int i = 0; i < hayStackChars.Length; i++)
//        {
//            for (int j = i; j < needleChars.Length; j++)
//            {
//                if (hayStackChars[i] == needleChars[j])
//                {
//                    if (counter == 0)
//                    {
//                        if (indexCount == 0)
//                        {
//                            indexCount = j;
//                            counter++;
//                        }
//                    }
//                    checkedArray[i] = needleChars[i];
//                    break;
//                }


//            }

//        }

//        if (new string(checkedArray) == needle)
//        {
//            return indexCount;
//        }
//        else if (new string(checkedArray) != needle)
//        {
//            return -1;
//        }
//        return -1;
//    }
//}

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int start = 0;
        char[] checkedArray = new char[needle.ToCharArray().Length];
        char[] hayStackChars = haystack.ToCharArray();
        char[] needleChars = needle.ToCharArray();

        for (int i = 0; i < hayStackChars.Length; i++)
        {
            if (hayStackChars[i] == needleChars[start])
            {
                checkedArray[start] = needleChars[start];
                start++;
                if (start == needleChars.Length)
                {
                    
                }
            }
            else if (hayStackChars[i] != needleChars[start])
            {
                start = 0;
            }
        }
    }
}

public class Program
{
    // Uygulamanın giriş noktası
    public static void Main(string[] args)
    {

    }
}