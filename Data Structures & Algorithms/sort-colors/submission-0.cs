public class Solution {
    public void SortColors(int[] nums) {
        int n = nums.Length;
        int mid = 0;
        int low = 0;
        int high = n - 1;

        while(mid <= high ){

            if(nums[mid] == 1){
                mid++;
            }
            else if (nums[mid] == 0){
                var temp = nums[mid];
                nums[mid] = nums[low];
                nums[low] = temp;
                mid++;
                low++;
            }
            else if (nums[mid] == 2){
                var temp = nums[mid];
                nums[mid] = nums[high];
                nums[high] = temp;
                high--;
            }
        }
    }
}