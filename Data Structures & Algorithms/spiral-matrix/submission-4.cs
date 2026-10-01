public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        int top = 0;
        int right = matrix[0].Length - 1;
        int bottom = matrix.Length - 1;
        int left = 0;
        List<int> result = new List<int>();

        while(top <= bottom && left <= right){
            for(int i = left; i <= right; i++){
                result.Add(matrix[top][i]);
            }
            top++;

            for(int j = top; j <= bottom; j++){
                result.Add(matrix[j][right]);
            }
            right--;



            if(top <= bottom){
            for(int k = right; k >= left; k--){
                result.Add(matrix[bottom][k]);
            }
            bottom--;
            }
            
                        
            if(left <= right){
            for(int l = bottom; l >= top; l--)
            {
                result.Add(matrix[l][left]);
            }
            left++;
            }
        }
        return result;
    }
}
