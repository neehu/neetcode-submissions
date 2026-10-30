public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int l = 0; int h = n - 1;
        int min = Int32.MaxValue;
        while(l <= h){
            int m = l + (h-l)/2;

            if( nums[m] >= nums[l] ){
                min = Math.Min(min,nums[l]);
                l = m + 1;
            } 
            else {
                min = Math.Min(min,nums[m]);
                h = m - 1;
            }
        }

        return min;
    }
}
