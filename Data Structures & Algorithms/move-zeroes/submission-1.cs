public class Solution {
    public void MoveZeroes(int[] nums) {
    int n = nums.Length;
    int swap = 0;
    for(int i = 0; i < n; i++){
        if(nums[i] == 0){
            swap = i;
            break;
        }
    }

    for(int j = swap; j < n ; j++){
        if(nums[j] != 0 && swap < n){
            var temp = nums[j];
            nums[j] = nums[swap];
            nums[swap] = temp;
            swap = swap + 1;
        }
    }
    }
}