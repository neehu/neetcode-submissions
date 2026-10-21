public class Solution {
    public int CharacterReplacement(string s, int k) {
        int n = s.Length;
        int[] count = new int[26];
        int maxLen = 0; int maxFreq = 0;
        int l = 0; int r = 0;

        while( r < n ){
            count[s[r] - 'A']++;
           maxFreq = Math.Max(maxFreq,count[s[r] - 'A']);

           if( ((r-l+1) - maxFreq) > k ){
            count[s[l] - 'A']--;
            l++;
           }

           maxLen = Math.Max(maxLen,(r-l+1));
           r++;
        }

        return maxLen;
    }
}
