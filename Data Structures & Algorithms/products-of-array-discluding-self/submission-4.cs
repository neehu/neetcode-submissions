public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        int product = 1;
        result[0] = 1;

        for(int i = 1; i < n; i++){
            product = product * nums[i-1];
            result[i] = product;
        }
        product = 1;
        for(int j = n - 2; j >= 0; j--){
            product = product * nums[j+1];
            result[j] *= product; 
        }

        return result;
    }
}
