public class Solution {
    public int MaxProduct(int[] nums) {
        int n = nums.Length;
        int prefix = 1;
        int suffix = 1;
        int max = nums[0];
       for(int i = 0; i < n; i++){
        if(prefix == 0) prefix = 1;
        if(suffix == 0) suffix = 1;

        prefix = prefix * nums[i];
        suffix = suffix * nums[n-1-i];
        int current = Math.Max(prefix,suffix);
        max = Math.Max(max,current);
       }
       return max;
}
}
