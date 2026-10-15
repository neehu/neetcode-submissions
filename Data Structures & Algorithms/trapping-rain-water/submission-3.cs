public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int l = 0; int r = n - 1;
        int leftMax = height[0]; int rightMax = height[r];
        int res = 0;
        while( l < r){

            if(leftMax <= rightMax){
                l++;
                leftMax = Math.Max(leftMax,height[l]);
                res = res + leftMax - height[l];
            }
            else {
                r--;
                rightMax = Math.Max(rightMax,height[r]);
                res = res + rightMax - height[r];
            }
        }
        return res; 
    }
}
