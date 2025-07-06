
//Gelen veriyi char'a dönüştür.
//En baştan index ile veriyi dolaş ilk parantezin karşılığı olan parantezi ara. Eğer yoksa false döndür.
//

public class Solution
{
    public bool IsValid(string s)
    {
        
    }
}

//Verilen s adlı bir dize yalnızca '(', ')', '{', '}', '[' ve ']' karakterlerini içeriyorsa, bu dize geçerli mi diye belirlemen isteniyor.
//Bir dize şu koşulları sağlıyorsa geçerlidir:
//Açılan parantezler, aynı türden kapama parantezleriyle kapatılmalıdır.
//Parantezler doğru sırada kapatılmalıdır.
//Her kapama parantezinin, karşılık gelen bir açma parantezi olmalıdır.

//Örnek geçerli dizeler:
//"()"
//"()[]{}"
//"{[]}"

//Geçersiz örnekler:
//"(]"
//"([)]"

//Example 1:
//Input: s = "()"
//Output: true

//Example 2:
//Input: s = "()[]{}"
//Output: true

//Example 3:
//Input: s = "(]"
//Output: false

//Example 4:
//Input: s = "([])"
//Output: true

//Yani hem eşleşme doğru olmalı (parantez türü), hem de sıra doğru olmalı (önce aç, sonra kapa).