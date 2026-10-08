public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int n = nums.Length;
        int i = 0;
        List<List<int>> pairs = new List<List<int>>();
        Array.Sort(nums);

        while ( i < n){

            while( i > 0 && i < n && nums[i - 1] == nums[i]) i++;
            int j = i + 1;
            int k = n - 1;

            while( j < k){

                long sum = (long) nums[i] + nums[j] + nums[k];

                if( sum == 0) {
                    var pair = new List<int>() { nums[i], nums[j], nums[k]};
                    pairs.Add(pair);

                    j++;
                    k--;

                    while( j < k && nums[j] == nums[j - 1]) j++;
                    while(j < k  && nums[k] == nums[k + 1]) k--;

                    
                }
                else if ( sum < 0){
                    j++;
                }
                else {
                    k--;
                }
            }
            i++;

        }
            return pairs;

    }
}
