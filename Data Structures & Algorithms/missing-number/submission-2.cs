public class Solution {
    public int MissingNumber(int[] nums) {
        Dictionary<int,int> hash = new Dictionary<int,int>();
        int n = nums.Length;

        for(int i  = 0; i < n; i++){
            hash.Add(nums[i],i);
        }

        for(int j = 0; j < n ; j++){
            if( !hash.ContainsKey(j)){
                return j;
            }
        }

        return n;
    }
}
