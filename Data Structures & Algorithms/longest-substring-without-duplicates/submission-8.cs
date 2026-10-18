public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;

        if(n == 0) return 0;

        int max = 1; int length = 0;
        int i = 0; int j = 1;
        Dictionary<int,int> hash = new Dictionary<int,int>();
        hash.Add(s[i],i);

        while(j < n){
        
            if( hash.ContainsKey(s[j]) && i != j)
            {
                hash.Remove(s[i]);
                i = i + 1;
                continue;
            }
            if( !hash.ContainsKey(s[j]) ) {
                hash.Add(s[j],j);
            }

            length = j - i + 1;
            max = Math.Max(length,max);
            j++;
        }

        return max;
    }
}
