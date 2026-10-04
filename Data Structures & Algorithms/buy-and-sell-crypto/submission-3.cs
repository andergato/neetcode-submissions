public class Solution {
    public int MaxProfit(int[] prices) {
        int max = prices[0];
        int min = prices[0];
        int profit = 0;

        foreach(int day in prices[1..]){
            if(day < min){
                min = day;
                max = day;
            }
            else if(day > max){
                max = day;
            }

            if((max - min) > profit){
                profit = max - min;
            }
        }

        return profit;
    }
}
