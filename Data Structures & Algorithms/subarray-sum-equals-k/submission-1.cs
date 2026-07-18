public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int n = nums.Length;
        int j = 0;
        int count = 0;
        int sum = 0;
        Dictionary<int,int> hash = new Dictionary<int,int>();
        hash[0] = 1;
        while(j < n){
            sum = sum + nums[j];
            int diff =  sum - k;

             if(hash.ContainsKey(diff)){
                count = hash[diff] + count;
            }
            if( hash.ContainsKey(sum)){
                hash[sum] += 1;
            }
            else {
                hash.Add(sum,1);
            }
            j++;
        }
        return count;
    }
}