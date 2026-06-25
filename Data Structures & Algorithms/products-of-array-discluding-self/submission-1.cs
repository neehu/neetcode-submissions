public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalProduct = 1;
        int n = nums.Length;
        int[] result = new int[n];
        
        result[0] = 1;

        for(int i = 1; i < n; i++){
            result[i] = result[i-1] * nums[i-1];
        }

        int right = 1;

        for(int k = n - 1; k >=0 ; k--){
            result[k] = result[k] * right;
            right = right * nums[k];
        }


               return result;
    }
}
