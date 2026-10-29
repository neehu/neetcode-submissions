public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int n = nums.Length;
        Dictionary<int,int> hash = new Dictionary<int,int>();
        int prefixSum = 0; int counter = 0;

        hash.Add(0,1);
        for(int i = 0 ; i < n; i++){

            prefixSum += nums[i];
            int diff = prefixSum - k;

            if(hash.ContainsKey(diff)){
                counter += hash[diff];
            }
             if(hash.ContainsKey(prefixSum)){
               hash[prefixSum] += 1;
            }
            else {
                hash.Add(prefixSum,1);
            }

        }

        return counter;
    }
}