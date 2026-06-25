public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalProduct = 1;
        int n = nums.Length;
        List<int> result = new List<int> ();

        for(int i = 0; i < n; i++){

            int product1 = 1;
            int j = 0;
            while(j <= i-1){
                product1 *= nums[j];
                j++; 
            }

            int product2 = 1;
            int k = i+1;

            while(k < n){
                product2 *= nums[k];
                k++;
            }
            result.Add(product1*product2);
        }
               return result.ToArray();
    }
}
