public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int l = 0;
        int r = n - 1;
        int m = (l+r)/2;

        while ( l <= r){

            m = (l+r)/2;

            if(nums[m] == target){
                return m;
            }
            else if(target > nums[m]){
                l = m+1;
            }
            else {
                r = m -1;
            }
        }

        return -1;
    }
}
