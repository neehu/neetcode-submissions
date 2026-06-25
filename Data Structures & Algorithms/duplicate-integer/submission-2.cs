public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);

        for( int i = 0; i+1 < nums.Length; i++){
            if( nums[i] == nums[i+1]){
                return true;
                break;
            }
        }

        return false;
    }
}