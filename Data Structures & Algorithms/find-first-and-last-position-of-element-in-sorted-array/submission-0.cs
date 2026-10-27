public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;
        int l = 0; int r = n - 1;
        int[] result = new int[2];
    Array.Fill(result,-1);
        while(l <= r){
            int m = (l+r)/2;
            if(nums[m] >= target){
                if(nums[m] == target){
                    result[0] = m;
                }
                r = m - 1;
            }
            else {
                l = m + 1;
            }
        }

        if(l == n){ 
            return result;

            }
     l = 0;  r = n - 1;
               while(l <= r){
            int m = (l+r)/2;
            if(nums[m] <= target){
                if(nums[m] == target){
                    result[1] = m;
                }
                l = m + 1;
            }
            else {
                r = m - 1;
            }
        }


        return result;
    }
}