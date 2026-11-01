public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int low = 0; int high = rows * cols - 1;

        while(low <= high){
            int mid = (high + low)/2;

           int row = mid/cols;
            int col = mid % cols;

            if(matrix[row][col] == target) { 
                return true;
            }
            else if(  target < matrix[row][col]){
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }

        return false;
    }
}
