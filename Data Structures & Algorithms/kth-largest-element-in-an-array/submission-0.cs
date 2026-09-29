public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int n = nums.Length;
        Array.Sort(nums);
        return nums[(n-k)];
    }
}
