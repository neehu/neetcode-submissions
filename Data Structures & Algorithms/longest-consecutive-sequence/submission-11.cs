public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        int count = 1;
        int maxCount = 1;

        var set = new HashSet<int>(nums);

        if (n == 0) return 0;

        foreach(var num in set){

            if(!set.Contains(num - 1)){
                count = 1;
                while(set.Contains(num + count)){
                    count++;
                    maxCount = Math.Max(count,maxCount);
                }
            }
        }
        return maxCount ;
    }
}
