public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int low = 0;
        int high = rows*cols-1;

        while(low <= high){
            int mid = (low+high)/2;
            int row = mid/cols;
            int col = mid % cols;
            int current = matrix[row][col];

            if(target == current){
                return true;
            }
            else if( target < current){
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }

        return false;
    }
}
