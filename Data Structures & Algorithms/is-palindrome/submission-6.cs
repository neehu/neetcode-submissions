public class Solution {
    public bool IsPalindrome(string s) {

        if(s.Length == 1) return true;
        
        var charArray = s.ToLower().Where(c => Char.IsLetterOrDigit(c)).ToArray();

        int n = charArray.Length;
        int i = 0;
        int j = n - 1;

        if(n == 0 || n == 1) return true;

        while(i < j ){

            if(charArray[i] != charArray[j]){
                return false;
            }

            i++;
            j--;

        }

        return true;
    }
}
