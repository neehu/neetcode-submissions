public class Solution {
    Dictionary<char,int> hash = new Dictionary<char,int>() 
    {
        {'I',1},
        {'V',5},
        {'X',10},
        {'L',50},
        {'C',100},
        {'D',500},
        {'M',1000}
    };
    public int RomanToInt(string s) {
        int n = s.Length;
        int total = 0; int prev = 0;
        for(int i = n-1; i >= 0; i-- ){

            int currentValue = hash[s[i]];

            if(currentValue < prev){
                total -= hash[s[i]];

            }
            else {
                total += hash[s[i]];
            }
            prev = hash[s[i]];

        }
        return total;

    }
}