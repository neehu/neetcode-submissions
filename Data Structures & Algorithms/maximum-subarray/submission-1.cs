public class Solution {
    public int MaxSubArray(int[] nums) {
        int n = nums.Length;
        int sum = 0;
        int maxSum = nums[0];
        int i = 0;

        while( i < n ){

             if( sum < 0){
                sum = 0;
            }
            sum = sum  + nums[i];
            maxSum = Math.Max(sum,maxSum);
            i++;

        }

        return maxSum;
    }
}
