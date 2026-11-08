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
        int total = 0; char prev = 'a';
        for(int i = n-1; i >= 0; i-- ){

            if(prev == 'V' && s[i] == 'I' || prev == 'X' && s[i] == 'I'){
                total -= hash[s[i]];

            }
            else if(prev == 'L' && s[i] == 'X' || prev == 'C' && s[i] == 'X'){
                total -= hash[s[i]];
            }
            else if(prev == 'D' && s[i] == 'C' || prev == 'M' && s[i] == 'C'){
                total -= hash[s[i]];
            }
            else {
                total += hash[s[i]];
            }
            prev = s[i];

        }
        return total;

    }
}