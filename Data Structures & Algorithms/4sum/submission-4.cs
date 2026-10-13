public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        int n = nums.Length;
        int i = 0;
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);

        while ( i < n ){
            
            int j = i + 1;

            while( j < n ){

                int l = j +  1;
                int k = n - 1;

                while( l < k){

                long sum =(long) nums[i] + nums[j] + nums[k] + nums[l];

                if ( sum == target){
                    result.Add( new List<int> () { nums[i], nums[j], nums[k], nums[l]} );

                    l++;
                    k--;

                    while( l < k && nums[l] == nums[l- 1]) l++;
                    while ( l < k && nums[k] == nums[k+ 1]) k--;
                }
                else if( sum < target){
                    l++;
                }
                else {
                    k--;
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