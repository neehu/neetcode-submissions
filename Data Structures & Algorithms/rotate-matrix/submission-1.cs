public class Solution {
    public void Rotate(int[][] matrix) {
        int m = matrix.Length;

        for(int i = 0; i < m; i++){
            for(int j = i + 1; j < m; j++){

                var temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        for(int k = 0; k < m; k++){
            int n = m - 1; 
            int l = 0;
            while( l < n){
                
                var temp = matrix[k][l];
                matrix[k][l] = matrix[k][n];
                matrix[k][n] = temp;
                n--;
                l++;
            }
        }
    }
}
