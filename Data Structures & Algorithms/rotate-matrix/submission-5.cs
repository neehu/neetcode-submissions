public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;

        //transpose
        for( int i = 0; i < n - 1; i++ ){
            for( int j = i + 1 ; j < n; j++ ){
                
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
            }
        }

        //reverse
        for(int k = 0; k < n; k++){
            for( int l = 0; l < n/2; l++){

                var temp = matrix[k][l];
                matrix[k][l] = matrix[k][n - 1 - l];
                matrix[k][n - 1 - l] = temp;
            }
        }


    }
}
