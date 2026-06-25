public class Solution {
    public int MaxArea(int[] nums) {

        int n = nums.Length;
        int maxArea = 0;
        int i = 0;
        int j = n - 1;

        while(i < j){

            int height = Math.Min(nums[i],nums[j]);
            int width = j - i;
            int area = height * width;
            maxArea = Math.Max(maxArea,area);

            if(height == nums[i]){
                i++;
            }
            else {
                j--;
            }
        }
       
        return maxArea;
    }
}
