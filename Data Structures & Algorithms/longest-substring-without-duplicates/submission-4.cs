public class Solution {
    public int LengthOfLongestSubstring(string s) {
            int n = s.Length;
            int maxCount = 0;
            int i = 0;
            Dictionary<char,int> hash = new Dictionary<char,int>();

            for(int j = 0; j < n; j++){
                char c = s[j];

                if(hash.ContainsKey(c) && hash[c] >= i){
                    i = hash[c] + 1;
                }

                hash[c] = j;
                maxCount = Math.Max(maxCount,j-i+1);
            }

            return maxCount;
    }
}
