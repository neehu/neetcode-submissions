public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        int count = 0;
        int maxCount = 0;

        if (n == 0) return maxCount;
        
        Array.Sort(nums);
        for(int i = 0, j= 1; j < n;i++, j++){

            if(nums[i] + 1 == nums[j]){
                count++;
                maxCount = Math.Max(count,maxCount);
            }
            else if(nums[i] == nums[j]){
                continue;
            }
            else {
                count = 0;
            }
        }

        return maxCount + 1 ;
    }
}
