public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        LinkedList<int> result = new LinkedList<int>();
        int[] max = new int[n-k+1];
        for (int i = 0; i < n; i++){

            if(result.Count > 0 && result.First.Value <= i - k){
                result.RemoveFirst();
            }

            while(result.Count > 0 && nums[result.Last.Value] < nums[i]){
                result.RemoveLast();
            }

            result.AddLast(i);
            if(i - k+1 >= 0){
                max[i-k+1] = nums[result.First.Value];
            }
        }

        return max;
    }
}
