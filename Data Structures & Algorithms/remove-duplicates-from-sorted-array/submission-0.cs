public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        int i = 0;
        int k = 1;
        int j = 1;

        while(i + 1 < n && j < n){
            if(nums[i] != nums[j]){
                var temp = nums[ i + 1];
                nums[i + 1] = nums[j];
                nums[j] = temp;
                i++;
                k++;
            }
            j++;
        }
              return k;
    }
}