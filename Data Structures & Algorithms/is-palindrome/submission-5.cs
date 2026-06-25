public class Solution {
    public bool IsPalindrome(string s) {

        if(s.Length == 1) return true;
        
        var charArray = s.ToLower().Where(c => Char.IsLetterOrDigit(c)).ToArray();

        int n = charArray.Length;
        int i = 0;
        int j = n - 1;
        bool isPalindrome = false;

        if(n == 0 || n == 1) return true;

        while(i < j ){
           
            if(!Char.IsLetterOrDigit(charArray[i])){
                i++;
                continue;
            }

            if(!Char.IsLetterOrDigit(charArray[j])){
                j--;
                continue;
            }

            if(charArray[i] == charArray[j] && i != j){
                isPalindrome = true;
            }

            else {
                isPalindrome = false;
                break;
            }

            i++;
            j--;

        }

        return isPalindrome;
    }
}
