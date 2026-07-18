public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int top = 0;int left = 0; int right = n - 1; int bottom = m - 1;
        List<int> result = new List<int>();
        while(left <= right && top <= bottom){

            for(int i = left; i <= right; i++){
            result.Add(matrix[top][i]);
            }

            top = top + 1;

            for(int i = top; i <= bottom; i++){
                result.Add(matrix[i][right]);
            }
            right = right - 1;

            if(top <= bottom){
            for(int i = right; i >= left; i-- ){
                result.Add(matrix[bottom][i]);
            }
            bottom = bottom - 1;
            }

            if(left <= right){
            for(int i = bottom; i >= top; i--){
                result.Add(matrix[i][left]);
            }
            left = left + 1;
            }
        }

        return result;
    }
}
