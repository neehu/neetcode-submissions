public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        int n = nums.Length;
        int i = 0;
        List<List<int>> pairs = new List<List<int>>();

        while( i < n ){
            int j = i + 1;

            while( j < n ){
                int k = j + 1;
                int l = n - 1;

                while(k < l){
                    long sum = (long) nums[i] + nums[j] + nums[k] + nums[l];

                    if(sum == target){
                        var pair = new List<int>() {nums[i],nums[j],nums[k],nums[l] };
                        pairs.Add(pair);
                        k++;
                        l--;

                        while ( k < l && nums[k] == nums[k-1]) k++;
                        while ( k < l && nums[l] == nums[l+1]) l--;
                    }
                    else if (sum < target){
                        k++;
                    }
                    else {
                        l--;
                    }
                }

                j++;
                while (j < n &&  nums[j] == nums[j - 1]) j++;
            }
            i++;
            while (i < n && nums[i] == nums[i-1] ) i++;
        }

        return pairs;
    }
}