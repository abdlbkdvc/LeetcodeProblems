



public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
            else if (nums[i] < target)
            {
                index = i + 1;
            }
            else if (nums[i] > target)
            {
                return index;
            }

        }
        return index;
    }
}
// Sıralı ve birbirinden farklı tamsayılardan oluşan bir dizi(nums) ile hedef(target) veriliyor. Hedef değer dizide bulunursa bulunduğu indeksi döndürsün.
// Bulunamazsa dizide sıralı kalacak şekilde eklenmesi gereken indeksi döndürün. 

//Example 1:

//Input: nums = [1, 3, 5, 6], target = 5
//Output: 2
//Example 2:S

//Input: nums = [1, 3, 5, 6], target = 2
//Output: 1
//Example 3:

//Input: nums = [1, 3, 5, 6], target = 7
//Output: 4

// Gelen dizide target'ı ara.
// Eğer varsa dizideki index sayısını dön.
// Eğer yoksa değerlerin büyüklüğüne göre sıralı bir şekilde hangi indexe gelecek hesapla.
// Daha sonra gelecek index'in sayısını dön.