public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int col0 = -1;
        int row0 = -1;

         for( int b = 0; b < cols; b++){
            if (matrix[0][b] == 0){
                col0 = 0;
                break;
            }
        }
        for( int c = 0; c < rows; c++){
           if(matrix[c][0] == 0){
            row0 = 0;
            break;
           }
        }

        for( int i = 1; i < rows; i++){
            for(int j = 1; j < cols; j++){

                if ( matrix[i][j] == 0 ){
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
                else if( matrix[0][j] == 0 || matrix[i][0] == 0 ){
                    matrix[i][j] = 0;
                }
            }
        }

        for( int k = rows - 1; k >= 0; k--){
            for(int l = cols - 1; l > 0; l--){
                 if( matrix[0][l] == 0 || matrix[k][0] == 0 ){
                    matrix[k][l] = 0;
                }
            }
        }

        if( row0 == 0)
        {
            for( int a = 0; a < rows; a++){
            matrix[a][0] = 0;
        }
        }

        if(col0 == 0){

          for( int z = 0; z < cols; z++){
            matrix[0][z] = 0;
        }
        }
    }
}
