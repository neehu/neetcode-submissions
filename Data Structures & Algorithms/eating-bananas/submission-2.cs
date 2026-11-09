public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int n = piles.Length;
        Array.Sort(piles);
        int low = 1; int high = piles[n-1];

        while(low < high ){
            int mid = low + ( high - low )/2;

            decimal total = 0;

            for(int i = 0; i < n; i++){
                var speed = (decimal) piles[i]/mid;

                if ( piles[i] % mid != 0){
                   speed = Math.Ceiling(speed);
                }
                total += speed;

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
