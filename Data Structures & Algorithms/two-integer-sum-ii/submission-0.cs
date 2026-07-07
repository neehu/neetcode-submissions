public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        int i = 0;
        int j = n - 1;
        int[] ans = new int[2];

        while(i <= j){

            int sum = nums[i] + nums[j];

            if(sum == target){
                ans[0] = i+1;
                ans[1] = j+1;
                return ans;
            }
            else if( sum < target){
                i++;
            }
            else {
                j--;
            }
        }

        return ans;
    }
}
