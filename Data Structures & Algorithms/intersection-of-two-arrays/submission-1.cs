public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);

        int i = 0;
        int j = 0;
        List<int> result = new List<int>();

        while (i < nums1.Length && j < nums2.Length) {

            if( nums1[i] == nums2[j] ) {
                result.Add(nums1[i]);
                i++;
                j++;
            }
            else if ( nums1[i] < nums2[j] ) {
                i++;
            }
            else {
                j++;
            }

        }
        return result.Distinct().ToArray();
    }
}