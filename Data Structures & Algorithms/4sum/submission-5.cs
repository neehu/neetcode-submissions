public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        int n = nums.Length;
        int i = 0;
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);

        while( i < n ){

            int j = i + 1;

            while( j < n ){
                
                int k = j + 1;
                int l = n - 1;

                while(k < l){
                    long sum = (long) nums[i] + nums[j] + nums[k] + nums[l];

                    if(sum == target){
                        var pairs = new List<int>(){ nums[i], nums[j], nums[k], nums[l] };
                        result.Add(pairs);

                        k++;
                        l--;

                        while( k < l && nums[k] == nums[k-1]) k++;
                        while (k < l && nums[l] == nums[l+1]) l--;
                     }

                     else if ( sum < target) {
                        k++;
                     }
                     else {
                        l--;
                     }
                }

                j++;
                while( j > 0 && j < n && nums[j] == nums[j-1]) j++;
            }

            i++;
            while( i > 0 && i < n && nums[i] == nums[i-1]) i++;
        }

        return result;
    }
}