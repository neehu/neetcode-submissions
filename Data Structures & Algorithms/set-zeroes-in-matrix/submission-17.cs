public class Solution {
    public void SetZeroes(int[][] matrix) {
        // save row0, and col0 values
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int row0 = -1;int col0 = -1;

        for(int i = 0; i < cols; i++ ){

            if(matrix[0][i] == 0) {
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
                    matrix[0][l] = 0;
                    matrix[k][0] = 0;
                }
            }
        }


        for(int a = 1; a < rows; a++){
            for(int b = 1; b < cols; b++ ){
                if(matrix[0][b] == 0  || matrix[a][0] == 0){
                    matrix[a][b] = 0;
                }

            }
        }

        if(col0 == 0){
             for(int c = 0; c < rows; c++ ){
                matrix[c][0] = 0;
            }
        }

        if(row0 == 0){
                   for(int d = 0; d < cols; d++ ){
                matrix[0][d] = 0;
            }
        }

        }
    }
