public class Solution {
    public int FindPeakElement(int[] nums) {
        int n = nums.Length;
        int low = 0; int high = n - 1;

        while(low < high){
            int mid = low + (high - low)/2;

            if(nums[mid] < nums[mid + 1]){
                low = mid + 1;
            }
            else {
                high = mid;
            }
        }
        return low;
    }
}