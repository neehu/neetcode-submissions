public class Solution {
    public int MaxProduct(int[] nums) {
        int n = nums.Length;
        int max = nums[0];
        int prefix = 1;
        int sufix = 1;

        for(int i = 0; i < n; i++){
            if(prefix == 0) prefix = 1;
            if(sufix == 0) sufix = 1;

            prefix *= nums[i];
            sufix *= nums[n-i-1];
            int currentMax = Math.Max(prefix,sufix);
            max = Math.Max(currentMax,max);
        }

        return max;
    }
}
