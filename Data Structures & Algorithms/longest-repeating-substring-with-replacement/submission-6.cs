public class Solution {
    public int CharacterReplacement(string s, int k) {
        int n = s.Length;
        int max = 0; int freq = 0;
        int[] c = new int[26];

        int i = 0; int j = 0;

        while( j < n){
            c[s[j]-'A']++;
            freq = Math.Max(freq,c[s[j]-'A']);
            int window = j - i + 1;

            if( window-freq > k  ){
                c[s[i]-'A']--;
                i++;
            }

            max = Math.Max(max,j-i+1);
            j++;
        }

        return max;
    }
}
