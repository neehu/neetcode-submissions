public class Solution {
    public bool IsAnagram(string s, string t) {
        var charArr = s.ToCharArray();
        Array.Sort(charArr);
        var charArr2 = t.ToCharArray();
        Array.Sort(charArr2);
        if(charArr.Length != charArr2.Length) return false;

        for (int i = 0; i < charArr.Length ; i++ ){
            if(charArr[i] != charArr2[i]){
                return false;
            }
        }

        return true;
    }
}
