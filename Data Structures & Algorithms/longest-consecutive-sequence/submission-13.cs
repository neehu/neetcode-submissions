public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        int max = 0;
        var hash = new HashSet<int>(nums);


      foreach( var num in hash){

        if(!hash.Contains(num - 1)){
            var current = num + 1;
            var length = 1;

            while(hash.Contains(current)){
                length++;
                current++;
            }
            max = Math.Max(max,length);
        }
      }

        return max;
    }
}
