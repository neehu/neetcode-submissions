public class Solution {
    public int LengthOfLongestSubstring(string s) {
    int n = s.Length;
    var chars = s.ToCharArray();
    int count = 0;
    int maxCount = 0;
    int i = 0;
    int j = 0;
    Dictionary<char,int> hash = new Dictionary<char,int>();

    while(i < n && j < n){

        if(!hash.ContainsKey(chars[j])){
            hash.Add(chars[j],j);
            count = count + 1;
            maxCount = Math.Max(count,maxCount);
            j++;
        }
        else {
            hash.Clear();
            count = 0;
            i = i + 1;
            j = i;
        }
    }

    return maxCount;
    }
}
