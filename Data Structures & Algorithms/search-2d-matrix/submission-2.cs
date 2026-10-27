public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length; int cols = matrix[0].Length;
        
        for(int i = 0; i < rows; i++){

            if( target >= matrix[i][0] &&  target <= matrix[i][cols-1]){

            int l = 0; int r = cols-1;
                
                while(l <= r){

                    int m = (l+r)/2;

                    if(matrix[i][m] == target){
                        return true;
                    }

                    if(matrix[i][m] > target){
                        r = m - 1;
                    }
                    
                    else {
                        l = m + 1;
                    }
                }
            }
        }

        return false;
    }
}
