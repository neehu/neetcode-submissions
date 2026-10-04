public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        int n = nums.Length;
        int i = 0;
        List<List<int>> pairs = new List<List<int>>();

        Array.Sort(nums);

        while( i < n - 3){

            int j = i + 1;
            
            while( j < n - 2){

                int k = j + 1;
                int l = n - 1; 
                

            while( k < l ){
               long sum = (long) nums[i] + nums[j] + nums[k] + nums[l];

                if( sum == target ){
                    var pair = new List<int> () { nums[i] , nums[j] , nums[k], nums[l]};
                    pairs.Add(pair);

                    k++; l--;

                    while( k < l && nums[k - 1] == nums[k]) k++;
                    while ( k < l && nums[l + 1] == nums[l]) l--;

                }

                else if( sum < target ){
                    k++;
                }
                else {
                    l--;
                }
            }
                j++;
                while( j < n - 2 && nums[j] == nums[j - 1] ) j++;
            }

            i++;
            while( i < n - 3 && nums[i] == nums[i - 1]) i++;
        }

        return pairs;
    }
}