public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int n = piles.Length;
        Array.Sort(piles);
        int high = piles[n-1];
        int low = 1; 

        while (low < high){
            int mid = low + (high - low)/2;
            long totalHours = 0;

            for(int i = 0; i < n;i++){
                totalHours += (piles[i]/mid);
                if(piles[i]%mid != 0){
                    totalHours +=  1; 
                }
            }

            if(totalHours <= h){
                    high = mid;
            }
            else{
                    low = mid + 1;
                }

        }

        return low;
    }
}
