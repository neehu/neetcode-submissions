public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int n = nums.Length;
        int i = 0;
        List<List<int>> triplets = new List<List<int>>();

        Array.Sort(nums);

        while( i < n ){
            int j = i + 1;
            int k = n - 1;

            while(j < k )
            {
                long sum = nums[i] + nums[j] + nums[k];

                if( sum == 0){
                    var triplet = new List<int>(){nums[i],nums[j],nums[k]};
                    triplets.Add(triplet);

                    j++;
                    k--;

                    while( j < k && nums[j] == nums[j-1]) j++;
                    while (k >= 0 && nums[k] == nums[k + 1]) k--;
                }

                else if (sum > 0){
                    k--;
                }
                else {
                    j++;
                }
            }
            i++;
            while( i < n && nums[i] == nums[i-1]) i++;
        }

        return triplets;
    }
}
