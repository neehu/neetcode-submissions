public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minimumPrice = prices[0];
        int n = prices.Length;

        for(int i = 1; i < n; i++){
            int profit = prices[i] - minimumPrice;
            maxProfit = Math.Max(maxProfit,profit);
            minimumPrice = Math.Min(prices[i], minimumPrice);
        }

        return maxProfit;
    }
}
