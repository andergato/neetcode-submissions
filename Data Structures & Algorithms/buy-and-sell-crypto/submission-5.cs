public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int profit = 0;

        foreach(int price in prices[1..]){
            profit = Math.Max(profit, price - min);
            min = Math.Min(min, price);
        }

        return profit;
    }
}
