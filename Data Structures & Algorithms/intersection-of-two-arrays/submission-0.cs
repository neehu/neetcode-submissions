public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Dictionary<int,int> hash = new Dictionary<int,int>();
        int m = nums1.Length;
        int n = nums2.Length;
        List<int> result = new List<int>();

        for(int i = 0; i < m; i++){
            if(hash.ContainsKey(nums1[i])){
                hash[nums1[i]] = i;
            }
            else {
                hash.Add(nums1[i],i);
            }
        }

        for(int j = 0; j < n; j++){
            if (hash.ContainsKey(nums2[j])){
                result.Add(nums2[j]);
            }
        }

        return result.Distinct().ToArray();
    }
}