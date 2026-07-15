public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int [] row = new int[rows];
        int[] col = new int[cols];

        for(int i = 0 ; i < rows; i++ ){
            for(int j = 0 ; j < cols; j++){

                if(matrix[i][j] == 0){
                    
                    row[i] = 1;
                    col[j] = 1;

                    //set previous rows as zero
                    int k = i-1;

                    while(k >= 0){
                        matrix[k][j] = 0;
                        k--;
                    }

                    //set previous columns as zero
                    int l = j - 1;
                    while(l >= 0){
                        matrix[i][l] = 0;
                        l--;
                    }

                }
                //set future rows or columns as  zero
                else if(row[i] == 1 || col[j] == 1){
                    matrix[i][j] = 0;
                }
            }
        }
    }
}
