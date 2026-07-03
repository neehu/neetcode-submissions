public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = nums.Length;
        int maxCount = 0;
        int count = 0;

        foreach (var num in nums){
            if(num == 1){
                count++;
                maxCount = Math.Max(count,maxCount);
            }
            else {
                count = 0;
            }
        }

        return maxCount;
    }
}