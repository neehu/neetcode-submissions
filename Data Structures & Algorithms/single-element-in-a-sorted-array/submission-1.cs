public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int n = nums.Length;
        int low = 0; int high = n - 1;

        while(low < high){
            int mid = low + (high - low)/2;

            if(mid%2 != 0){
                mid--;
            }

            if(nums[mid] == nums[mid+1]){
                mid++;
                low = mid + 1;
            }
            else {
                high = mid;
            }
        }

        return nums[low];        
        
}
}
