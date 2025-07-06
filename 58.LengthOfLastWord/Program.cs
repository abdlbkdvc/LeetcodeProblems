
// İlk başta her gelen inputu karakterlere ayır.
// Daha sonra en son index'ten aşağı doğru her harf gördüğünde sayaç bir artsın.
// Eğer harften sonra '' ifadesine denk gelirse döngüyü bitirsin.
// En sonda da '' boşluklardan olması hiçbir problem oluşturmaz. Çünkü ' ' olmadığı yerde sayaç değeri +1 artacak.

Solution solution = new Solution();
solution.LengthOfLastWord("   fly me   to   the moon  ");

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        char[] inputChars = s.ToCharArray();
        int counter = 0;
        bool conditionToGetWord = false;

        for (int i = inputChars.Length - 1; i >= 0; i--)
        {
            if (inputChars[i] != ' ')
            {
                counter++;
                conditionToGetWord = true;
            }
            else if (conditionToGetWord)
            {
                break;
            }
        }
        return counter;
    }
}
// Birden çok kelime ve boşluklardan oluşan s dizesi veriliyor. Dizideki son kelimenin uzunluğunu döndürün.

// Example 1:
//Input: s = "Hello World"
//Output: 5
//Explanation: The last word is "World" with length 5.

//Example 2:
//Input: s = "   fly me   to   the moon  "
//Output: 4
//Explanation: The last word is "moon" with length 4.

//Example 3:
//Input: s = "luffy is still joyboy"
//Output: 6
//Explanation: The last word is "joyboy" with length 6.


