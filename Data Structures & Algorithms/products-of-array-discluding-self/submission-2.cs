public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var res = new int[n];
        res[0] = 1;
        if(n == 0) return res;

        int mult = 1;

        for(int i = 1; i < n ; i++){
            mult = mult * nums[i-1];
            res[i] = mult;
        }
        mult = 1;

        for(int j = n-2; j >= 0; j--){
            mult = mult * nums[j+1];
            res[j] = res[j] * mult;
        }

       return res;
    }
}
