public class Solution {
    public int CharacterReplacement(string s, int k) {
        int n = s.Length;
        int i = 0;
        int[] lastSeen = new int[128];
        int maxFreq = 0;
        int maxCount = 0;
        Array.Fill(lastSeen,0);

        for(int j = 0; j < n; j++){
            char c = s[j];

            lastSeen[c] = lastSeen[c] + 1;
            maxFreq = Math.Max(maxFreq,lastSeen[c]);
            int windowSize = j - i + 1;

            if(windowSize - maxFreq <= k){
                    maxCount = Math.Max(maxCount,windowSize);
            }
            else{
                lastSeen[s[i]]--;
                i = i + 1;
            }
            

        }

        return maxCount;
        
    }
}
