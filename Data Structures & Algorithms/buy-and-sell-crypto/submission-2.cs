public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        if(n == 0) return 0;
        int mp = prices[0];
        int maxp = 0;
        for( int i = 1; i < n; i++){
            int profit = prices[i] - mp;
            maxp = Math.Max(profit,maxp);
            mp = Math.Min(prices[i],mp);    
        }

        return maxp;
    }
}
