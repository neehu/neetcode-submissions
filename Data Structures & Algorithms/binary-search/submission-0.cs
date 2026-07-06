public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int low = 0;
        int high = n - 1;
        int mid = (low+high)/2;

       return SearchRecursive(nums,low,high,target);
    }

    public int SearchRecursive(int[] nums,int low , int high,int target){
        if(low > high){
            return -1;
        }

        int mid = (high + low)/2;

        if(nums[mid] == target){
            return mid;
        }

        else if(target < nums[mid]){
            high = mid - 1;
        }
        else{
            low = mid + 1;
        }
       return SearchRecursive(nums,low ,high,target);
    }
}
