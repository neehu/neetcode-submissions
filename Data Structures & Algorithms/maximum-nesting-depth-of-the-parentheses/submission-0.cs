public class Solution {
    public int MaxDepth(string s) {
        int n = s.Length;
        int depth = 0; int max = 0;
        for(int i = 0; i < n; i++){
            if(s[i] == '('){
                depth++;
                max = Math.Max(depth,max);
            }
            else if(s[i] == ')') {
                depth--;
            }
        }

        return max;
    }
}