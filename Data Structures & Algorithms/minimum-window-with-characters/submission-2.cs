public class Solution {
    public string MinWindow(string s, string t) {
        int n = s.Length;
        int[] hash1 = new int[128];
        Dictionary<char,int> hash2 = new Dictionary<char,int>();

        foreach(var c in t){
            hash1[c] += 1;
        }

        int i = 0;
        int j = 0;
        string result = "";
        int required = t.Length;


        while(j < n){
            var c2= s[j];

            if( hash1[c2] != 0 ){
                if(hash2.ContainsKey(c2)){
                    hash2[c2] += 1;
                }
                else{
                    hash2.Add(c2,1);
                }
                if(hash2[c2] <= hash1[c2]){
                    required--;
                }
            }
               while(required == 0){
                int length = j - i + 1;
                if(result == "" || length < result.Length){
                    result = s.Substring(i,length);
                }
                char c = s[i];
                if(hash1[c] != 0){
                    hash2[c] --;
                    if(hash2[c] < hash1[c]){
                        required++;
                    }
                }
                i++;
               }
            j++;
        }

        return result;
    }
}
