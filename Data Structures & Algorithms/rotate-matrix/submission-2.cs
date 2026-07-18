public class Solution {
    public void Rotate(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        //transpose
        for(int i = 0; i < m; i++){
            for(int j = i + 1; j < n; j++){

                if(i == j) continue;
                var temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        //reverse
        for(int i = 0; i < m; i++){
            int l = n - 1;
            for(int j = 0; j < l; j++,l--){
               var temp = matrix[i][j];
               matrix[i][j] = matrix[i][l];
               matrix[i][l] = temp; 
            }
        }
    }
}
