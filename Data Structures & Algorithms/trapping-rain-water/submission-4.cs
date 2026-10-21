public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int l = 0; int r = n - 1;
        int total = 0;
        int maxLeft = height[l]; int maxRight = height[r];
        while( l < r){

            if ( height[l] <= height[r]){
                l++;
                maxLeft = Math.Max(height[l],maxLeft);
                total = total + maxLeft - height[l];
            }
            else {
                r--;
                maxRight = Math.Max(height[r],maxRight);
                total = total + maxRight - height[r];
            }
        }

        return total;
    }
}
