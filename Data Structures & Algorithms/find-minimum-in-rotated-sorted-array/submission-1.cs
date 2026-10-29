public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int min = Int32.MaxValue; int low = 0; int high = n -1;
        while(low <= high){
             int mid = low + (high - low) / 2;

            if(nums[mid] >= nums[low]){
                min = Math.Min(min,nums[low]);
                low = mid  + 1;
            }
            else {
                min = Math.Min(min,nums[mid]);
                high = mid - 1;
            }
            }
            return min;
        }
    }
