public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var hash = new HashSet<int>(nums1);
        int m = nums1.Length;
        int n = nums2.Length;
        List<int> result = new List<int>();


        for(int j = 0; j < n; j++){
            if (hash.Contains(nums2[j])){
                result.Add(nums2[j]);
                hash.Remove(nums2[j]);
            }
        }

        return result.ToArray();
    }
}