public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int n = piles.Length;
        int low = 1; int high = piles[0];

        for(int i = 0; i < n ; i++){
            high = Math.Max(piles[i],high);
        }

        while(low < high ){
            int mid = low + ( high - low )/2;

            decimal total = 0;

            for(int i = 0; i < n; i++){
                total +=  piles[i]/mid;

                if ( piles[i] % mid != 0){
                  total++;
                }

            }

            if( total <= h){
                high = mid;
            }
            else {
                low = mid + 1;
            }
        }

        return low;
    }
}
