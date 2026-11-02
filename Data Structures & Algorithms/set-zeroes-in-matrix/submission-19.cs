public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int row0 = -1; int col0 = - 1;

        for(int i = 0 ; i < cols; i++){
            if(matrix[0][i] == 0){
                row0 = 0;
                break;
            }
        }

        for(int j = 0; j < rows; j++){
            if(matrix[j][0] == 0){
                col0 = 0;
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

        for(int m = rows - 1; m > 0; m--){
            for(int n = cols - 1; n > 0; n--){
                if(matrix[0][n] == 0 || matrix[m][0] == 0){
                    matrix[m][n] = 0;
                }
            }
        }

        if(row0 == 0){
            for(int o = 0; o < cols; o++){
                matrix[0][o] = 0;
            }
        }

                if(col0 == 0){
            for(int p = 0; p < rows; p++){
                matrix[p][0] = 0;
            }
        }
    }
}
