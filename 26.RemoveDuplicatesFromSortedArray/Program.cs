

int[] values = new int[] { 5, 4, 3, 1, 3 };
Solution solution = new Solution();

solution.RemoveDuplicates(values);

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int tempData = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    tempData = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tempData;
                }
            }
        }
        int k = 1;

        // 1, 3, 3, 4, 5
        for (int i = 1; i < nums.Length; i++)
        {

            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }


        }
        return k;
    }

}

// Çözülecek daha çözülmedi
// eğer ki aynı değerse yazdır samevalue değerini +1 arttır eğer bir daha aynı veri gelirse atla.


//Azalmayan düzende sıralanmış bir tam sayı dizisi nums verildiğinde, her benzersiz öğenin yalnızca bir kez görünmesi için yinelenenleri yerinde kaldırın.
//Öğelerin göreli sırası aynı tutulmalıdır. Ardından nums'daki benzersiz öğelerin sayısını döndürün.
//nums'ın benzersiz öğelerinin sayısının k olduğunu düşünün, kabul edilmek için aşağıdaki şeyleri yapmanız gerekir:
//nums dizisini, nums'ın ilk k öğesinin benzersiz öğeleri nums'da başlangıçta mevcut oldukları sırayla içerecek şekilde değiştirin.
//nums'ın kalan öğeleri ve nums'ın boyutu önemli değildir. k'yi döndürün.

//Example 1:

//Input: nums = [1, 1, 2]
//Output: 2, nums = [1, 2, _]
//Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).
//Example 2:

//Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]
//Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]
//Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
//It does not matter what you leave beyond the returned k (hence they are underscores).

//YOL
//İlk başta verileri soldan sağa doğru büyükten küçüğe doğru sıralanmalı.
//Bir array kontrolü olduğu için döngü ile içerisindeki verileri kontrol edeceğim.
//Eğer birden fazla aynı veri varsa tekrar eden veri bulunacak.
//Daha sonra o veri çıkarılacak return edilirken. Bunun için ekstra bir array kullanılabilir.








// Worst Case => [10,9,8,7,6,5,12]
// Best Case => [12,10,9,8,7,6,5]