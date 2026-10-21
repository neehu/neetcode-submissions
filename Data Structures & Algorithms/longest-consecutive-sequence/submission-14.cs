public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        int max = 0;
        HashSet<int> hash = new HashSet<int>(nums);

        foreach( var num in nums){

            if(!hash.Contains(num-1)){
                int length = 0;
                int curr = num;

                while( hash.Contains(curr)){
                    curr++;
                    length++;
                }

                max = Math.Max(max,length);
            }
        }

        return max;
    }
}
