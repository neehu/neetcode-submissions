public class Solution {
    public int FindPeakElement(int[] nums) {
        int n = nums.Length;
        int low = 0; int high = n - 1;
        int mid = 0;
        while(low < high ){
            mid = low + (high - low)/2;

            if(nums[mid + 1] > nums[mid]){
                low = mid + 1;
            }
            else {
                high = mid;
            }
        }

        return high;
    }
}