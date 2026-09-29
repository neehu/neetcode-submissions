public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int l  = k % n;
        Reverse(nums, 0,n-l-1);
        Reverse(nums,n-l,n-1);
        Reverse(nums,0,n-1);
    }

    public void Reverse(int[] nums,int l,int r){
        while(l <= r){
            var temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;
            l++;
            r--;
        }
    }
}