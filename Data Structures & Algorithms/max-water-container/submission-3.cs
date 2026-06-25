public class Solution {
    public int MaxArea(int[] nums) {

        int n = nums.Length;
        int maxArea = 0;

        for(int i = 0 ; i < n; i++){
            for(int j = 0; j < n; j++){
                if(nums[j] <= nums[i] && i != j){
                    int height = nums[j];
                    int width =  Math.Max(j,i) - Math.Min(j,i);
                    int area = width * height;
                    maxArea = Math.Max(area,maxArea);
                }
            }
        }
        return maxArea;
    }
}
