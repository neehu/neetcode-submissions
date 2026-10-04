public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        int n = nums.Length;
        int i = 0;
        List<List<int>> pairs = new List<List<int>>();

        Array.Sort(nums);

        while( i < n){

            while( i > 0 && i < n && nums[i - 1] == nums[i]) i++;

            int j = i + 1;
            
            while( j < n){

                while ( j > i + 1 && j < n && nums[ j - 1] == nums [j]) j++;


                int k = j + 1;
                int l = n - 1; 
                

            while( k < l ){
                long x = (long) nums[i] ;
                long y = (long) nums[j] ;
                long z = (long) nums[k] ;
                long a = (long) nums[l];
               long sum = ( x + y + z + a);

                if( sum == target ){
                Console.WriteLine(sum);
                    var pair = new List<int> () { nums[i] , nums[j] , nums[k], nums[l]};
                    pairs.Add(pair);

                    k++;
                    l--;

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
            }

            i++;
        }

        return pairs;
    }
}