public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int min = Int32.MaxValue; int max = Int32.MinValue;

        foreach(var price in prices){
            min = Math.Min(min,price);
            int profit = price - min;
            max = Math.Max(max,profit);
        }

        return max;
    }
}
