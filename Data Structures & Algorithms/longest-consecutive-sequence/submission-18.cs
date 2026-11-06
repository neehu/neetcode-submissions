public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        HashSet<int> hashSet = new HashSet<int>(nums);
            int max = 0;
        foreach(var hash in hashSet){

            if( !hashSet.Contains(hash-1)){
                int curr = hash;
                int len = 0;

                while (hashSet.Contains(curr)){
                    curr++;
                    len++;
                }
                max = Math.Max(max,len);
            }
        }

        return max;
    }
}
