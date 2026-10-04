public class Solution {
    public int MaxProfit(int[] prices) {
        int max,min;
        max = min = prices[0];
        int profit = 0;

        foreach(int day in prices[1..]){
            if(day < min){
                min = max = day;
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
