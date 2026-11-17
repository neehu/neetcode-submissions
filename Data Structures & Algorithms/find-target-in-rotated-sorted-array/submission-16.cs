public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int low = 0; int high = n - 1;
        int index = -1;

        while (low <= high ){
            int mid = low + (high - low)/2;


            if ( nums[low] <= nums[mid]){
                if(nums[low] <= target && target <= nums[mid]){
                    index = mid;
                    high = mid - 1;
                }
                else {
                    low = mid + 1;
                }
            }
            else {

                if(nums[mid] <= target && target <= nums[high]){
                    index = mid;
                    low = mid + 1;
                }
                else {
                    high = mid - 1;
                }
            }
        }
        if(index >= 0 && nums[index] == target) return index;
        else return -1;
    }
}
