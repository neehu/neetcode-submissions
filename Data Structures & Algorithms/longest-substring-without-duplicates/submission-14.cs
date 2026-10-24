public class Solution {
    public int LengthOfLongestSubstring(string s) {
            int n = s.Length;

        int i = 0; int j = 0;
        Dictionary<int,int> hash = new Dictionary<int,int>();
        int max = 0;

        while(i < n && j < n){

          if(hash.ContainsKey(s[j])){
            hash.Remove(s[i]);
            i++;
            continue;
          }
 
        hash.Add(s[j],1);

          int window = j - i + 1;
          max = Math.Max(max,window);
          j++;
        }

        return max;
    }
}
