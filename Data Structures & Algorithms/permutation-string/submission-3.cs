public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int n = s1.Length;
        int n2 = s2.Length;
        int[] hash = new int[128];
        int[] hash2 = new int[128];
        Array.Fill(hash,0);
        Array.Fill(hash2,0);

        for(int i = 0 ; i < n; i++){
            hash[s1[i]] += 1;
        }

        int k = 0;
        for(int j = 0; j < n2; j++){
            char c = s2[j];
            hash2[c]+=1;
            int window = 0;

            while(hash2[c] > hash[c]){
                hash2[s2[k]]--;
                k++;
            }

                window = j - k + 1;
             
            if(window == n){
            return true;
            }
             
        }
        return false;
        }

    }
