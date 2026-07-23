public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int i = 0;
        int j = nums.Length - 1;
        int[] result = new int[2];
        int[] original = (int[])nums.Clone();
        
        Array.Sort(nums);

        while (i < j){
            int sum = nums[i] + nums[j];

            if(sum == target){
                int idx1 = -1, idx2 = -1;
                for(int k = 0; k < original.Length; k++){
                    if(original[k] == nums[i] && idx1 == -1) idx1 = k;
                    else if(original[k] == nums[j]) idx2 = k;
                }
                result[0] = Math.Min(idx1, idx2);
                result[1] = Math.Max(idx1, idx2);
                break;
            }
            else if(sum < target){
                i++;
            }
            else {
                j--;
            }
        }

        return result;
    }
}