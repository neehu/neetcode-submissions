public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int n = nums.Length;
        int low = 0;
        int high = n - 1;

        while(low < high){

            int mid = (low+high)/2;

            if(nums[mid] == target){

                return mid;
            }

            if(nums[mid] >= target){
                high = mid - 1;
            }
            else{
                low = mid + 1;
            }
        }
        
        if(nums[low] < target){ return low + 1;}

        return low;
    }
}