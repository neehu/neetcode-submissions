public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int left = 0; int right = n - 1;
        int maxLeft = height[left]; int maxRight = height[right];
        int totalWater = 0;

        while(left < right){
            if(height[left] <= height[right]){
                left++;
                maxLeft = Math.Max(height[left],maxLeft);
                totalWater += maxLeft - height[left];
            }
            else {
                right--;
                maxRight = Math.Max(height[right],maxRight);
                totalWater += maxRight - height[right];
            }
        }

        return totalWater;
    }
}
