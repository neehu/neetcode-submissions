public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int i = 0;
        int low = 0; int high = n - 1;
        int min = nums[low];
        while (low <= high){
            
        int mid = low + (high - low)/2;

        if(nums[low] <= nums[mid]){

            min = Math.Min(min,nums[low]);
            low = mid + 1;
        }
        else {
            if(nums[mid] <= nums[high]){
            min = Math.Min(min,nums[mid]);
            high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        }

        return min;
    }
}
