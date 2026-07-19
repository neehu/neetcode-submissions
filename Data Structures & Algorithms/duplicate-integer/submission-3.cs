public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> hash = new Dictionary<int,int>();

        foreach(var num in nums){
            if(hash.ContainsKey(num)){
                return true;
            }
            hash.Add(num,0);
        }

        return false;
    }
}