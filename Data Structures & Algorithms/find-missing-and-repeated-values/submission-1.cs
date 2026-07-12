public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int n = grid.Length;
        int[] result = new int[2];
        Dictionary<int,int> hash = new Dictionary<int,int>();

        int min = 1;
        int max = n*n;

        for(int i = 0 ; i < n; i++){
            for(int j = 0 ; j < n; j++){
                int current = grid[i][j];

                if(hash.ContainsKey(current)){
                     hash[current] += 1;
                    if(hash[current] >= 2){
                    result[0] = current;
                    }
                }
                else{
                    hash.Add(current,1);
                }
            }
        }

        for(int k = min; k <= max;k++){
            if(!hash.ContainsKey(k)){
             result[1] = k;
            }
        }

        return result;
    }
}