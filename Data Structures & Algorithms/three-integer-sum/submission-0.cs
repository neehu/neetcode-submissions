public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);
        int i = 0;
        int n = nums.Length;

        while( i < n){

            //check for duplicates
            if( i != 0 && nums[i] == nums[i-1]) {i++;continue;}

            int j = i + 1;
            int k = n - 1;

            while(j < k){

                int sum = nums[i] + nums[j] + nums[k];
                
                if(sum == 0){
                    result.Add(new List<int>(){nums[i],nums[j],nums[k]});

                    j++;
                    k--;

                    while(j < k && nums[j] == nums[j-1]) j++;
                    while(j < k && nums[k] == nums[k+1]) k--;
                }

                else if( sum < 0){
                    j++;
                }
                else {
                    k--;
                }
            }

            i++;
        }
    return result;
    }
}
