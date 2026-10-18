public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int max = 0;
        int i = 0; int j = 0;
        HashSet<char> hash = new HashSet<char>();

        while(j < n){

            if( hash.Contains(s[j]) )
            {
                hash.Remove(s[i]);
                i++;
                continue;
            }

            hash.Add(s[j]);
            max = Math.Max(max, j - i + 1);
            j++;
        }

        return max;
    }
}