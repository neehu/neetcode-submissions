public class Solution {
    public int MaxSubArray(int[] nums) {
        int n = nums.Length;
        int prefix = 0;
        int max = nums[0];
        for(int i = 0; i < n; i++){
            prefix += nums[i];
            max = Math.Max(max,prefix);

            if(prefix < 0){
                prefix = 0;
            }
        }

        return max;
    }
}
