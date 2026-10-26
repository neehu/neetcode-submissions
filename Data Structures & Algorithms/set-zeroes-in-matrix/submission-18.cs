public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int row0 = -1; int col0 = -1;

        for(int i = 0; i < rows; i++){
            if(matrix[i][0] == 0){
                col0 = 0;
                break;
            }
        }

        for(int j = 0; j < cols; j++){
            if(matrix[0][j] == 0){
                row0 = 0;
                break;
            }
        }

        for(int k = 1; k < rows; k++){
            for(int l = 1; l < cols; l++){

                if(matrix[k][l] == 0){
                    matrix[k][0] = 0;
                    matrix[0][l] = 0;
                }
            }
        }

        for(int m = rows - 1; m >= 0; m--){
            for(int n = cols - 1; n >=0; n--){
                if(matrix[m][0] == 0 || matrix[0][n] == 0){
                    matrix[m][n] = 0;
                }
            }
        }

        if(row0 == 0) {
            for(int p = 0; p < cols; p++){
                matrix[0][p] = 0;
            }
        }

        if(col0 == 0){
            for(int q = 0; q < rows; q++){
                matrix[q][0] = 0;
            }
        }
    }
}
