public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var hash = new Dictionary<int,int>();
        int n = nums.Length;
        List<int> result = new List<int>();
        
        for(int i = 0 ; i < n; i++ ){

            if(hash.ContainsKey(nums[i])){
                hash[nums[i]] += 1;
            }
            else 
            {
                hash.Add(nums[i],1);
            }
        }

            var descValues = hash.Values.ToArray();
            Array.Sort(descValues);
            Array.Reverse(descValues);
descValues = descValues.Take(k).ToArray();
        foreach(var key in hash){
            if(result.Count == k){
                break;
            }
            if(descValues.Contains(key.Value)){
                result.Add(key.Key);
            }
        }
        return result.ToArray();
    }
}
