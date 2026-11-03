public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;

        if( m > n) return FindMedianSortedArrays(nums2,nums1);

        int low = 0 ; int high = m;
        int leftSize = (m+n+1)/2;
        while(low <= high){
            int i = low + (high - low)/2;
            int j = leftSize - i;

            int left1 = (i == 0) ? int.MinValue : nums1[i-1];
            int right1 = (i == m) ? int.MaxValue : nums1[i];
            int left2 = (j == 0) ? int.MinValue : nums2[j - 1];
            int right2 = (j == n) ? int.MaxValue : nums2[j];

            if(left1 <= right2 && left2 <= right1){
              int leftMax = Math.Max(left1,left2);
              if((m+n)%2 == 1){
                return leftMax;
              }

              int rightMin = Math.Min(right1,right2);
              return ((double)leftMax + rightMin)/2.0;
            }

            if(left1 > right2){
                high = i - 1;
            }
             else{
                low = i + 1;
             }
        }

        return 0.0;
    }
}
