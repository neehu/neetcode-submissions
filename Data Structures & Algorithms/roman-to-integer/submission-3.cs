public class Solution {
    public int RomanToInt(string s) {
        int n = s.Length;
        Dictionary<char,int> hash = new Dictionary<char,int>()
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C', 100},
            {'D',500},
            {'M', 1000}
        };
        int prev = hash[s[n-1]];
        int total = prev;
        for(int i = n-2 ; i >= 0; i--){
            
            var current = hash[s[i]];

            if( current < prev){
                total -= current;
            }
            else {
            total += current;
            }
            prev = current;
            
        }

        return total;
    }
}