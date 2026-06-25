public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> hash = new Dictionary<int,int>();

        for( int i = 0; i < nums.Length; i++){

            if(hash.ContainsKey(nums[i])){
                return true;
                break;
            }
            else {
                hash.Add(nums[i],i);
            }
        }

        return false;
    }
}