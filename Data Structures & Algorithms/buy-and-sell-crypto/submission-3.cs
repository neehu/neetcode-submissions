public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0] ;  int profit = 0;
        foreach(var num in prices){
            min = Math.Min(min,num);
            profit = Math.Max(profit,num-min);
        }

        return profit;
    }
}
