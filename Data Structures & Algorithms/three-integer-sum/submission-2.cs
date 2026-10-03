public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int n = nums.Length;
        int i = 0;
        Array.Sort(nums);
        List<List<int>> pairs = new List<List<int>>();

        while( i < n ){

        while(  i != 0 && i < n && nums[i] == nums[i-1]) i++;
           int j = i + 1;
           int k = n - 1;

            while( j < k) {

                int sum = nums[i] + nums[j] + nums[k];

                if( sum == 0 ){
                    var pair =  new List<int>() { nums[i], nums[j], nums[k]};
                    pairs.Add(pair);

                    j++;
                    k--;

                    while( j < k && nums[j] == nums[j - 1] ) j++;
                    while ( k >=0 && nums[k] == nums[k + 1] ) k--;
                }

                else if ( sum < 0 ){
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
