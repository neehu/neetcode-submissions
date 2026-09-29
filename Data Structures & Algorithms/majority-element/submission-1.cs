public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Length ;
        int count = 1;
        int maxCount = 0;
        int element = nums[0];
       

        for(int i = 1; i < n; i++){
             if( count == 0){
            count = 1;
            element = nums[i];
           }

            else if(nums[i] == element){
                count++;
            }
           
            else {
                count--;
            }
        }
        return element;
    }
}