public class Solution {
    public int CharacterReplacement(string s, int k) {
        int n = s.Length;
        int[] freq = new int[26];
        int maxFreq = 0;
        int max = 1;

        int i = 0; int j = 0;

        while (j < n){
            freq[s[j] - 'A']++;
            maxFreq = Math.Max(maxFreq,freq[s[j]-'A']);

            if( (j - i + 1) - maxFreq > k){
                freq[s[i]-'A']--;
                i++;
            }

            max = Math.Max(max,(j-i+1));
            j++;
        }

        return max;
    }
}
