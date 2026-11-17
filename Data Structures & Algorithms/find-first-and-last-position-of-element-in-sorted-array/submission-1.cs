public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;
        int low = 0; int high = n - 1;
         int[] result = new int[2];
         Array.Fill(result,-1);

        while( low <= high ){

        int mid = low + (high-low)/2;

        if(nums[mid] == target){
            result[1] = mid;
        }
            if( nums[mid] <= target){
                low = mid + 1;
            }
            else {
                high = mid - 1;
            }
        }

    low = 0; high = n - 1;

    while (low <= high){
        int mid = low + (high-low)/2;
if(nums[mid] == target){
            result[0] = mid;
        }
        if(nums[mid] >= target){
            high = mid - 1;
        }
        else {
            low = mid + 1;
        }
    }

    return result;
}
}