public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        int difference = 0;
        var result = new int[2];
        Dictionary<int,int> hash = new Dictionary<int,int>();

        for(int i = 0; i < n; i++){
            difference = target - nums[i];

            if(hash.ContainsKey(difference)){
                result[0] = Math.Min(i,hash[difference]);
                result[1] = Math.Max(i,hash[difference]);
                break;
            }
            else if (hash.ContainsKey(nums[i])){
                hash[nums[i]] = i;
            }

            hash.Add(nums[i],i);
        }

        return result;
    }
}
