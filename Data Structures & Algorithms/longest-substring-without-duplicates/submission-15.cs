public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        Dictionary<char,int> hash = new Dictionary<char,int>();
        int maxLen = 0;
        int i = 0; int j = 0;

        while(j < n){

         if(hash.ContainsKey(s[j])){
            hash.Remove(s[i]);
            i = i + 1;
            continue;
         } 
            hash.Add(s[j],1);
         maxLen = Math.Max(maxLen, j - i + 1);
         j++;   
            
        }
        return maxLen;
    }
}
