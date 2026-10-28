public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        int max = 0;
        HashSet<int> hash = new HashSet<int>(nums);

        for(int i = 0; i < n; i++){

            if(!hash.Contains(nums[i] - 1)){
                int len = 0;
                int current = nums[i];

                while(hash.Contains(current)){
                    current++;
                    len++;
                }

                max = Math.Max(len,max);
            }
        }

        return max;
    }
}
