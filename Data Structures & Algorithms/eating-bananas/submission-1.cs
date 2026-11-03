public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int n = piles.Length;
        int low = 1;
        int high = Int32.MinValue;

        for(int i = 0; i < n ; i++){
            high = Math.Max(piles[i],high);
        }

        while( low < high ){
            int mid = low + (high -low)/2;
            int totalHours = 0;

            for(int j = 0; j < n; j++){
                totalHours += (piles[j]/mid);

                if(piles[j]%mid != 0){
                    totalHours += 1;
                }
            }

            if(totalHours <= h){
                high = mid;
            }
            else {
                low = mid + 1;
            }
        }

        return low;
    }
}
