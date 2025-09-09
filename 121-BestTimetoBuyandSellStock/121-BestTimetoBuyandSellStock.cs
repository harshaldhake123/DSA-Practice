// Last updated: 9/9/2025, 9:37:32 PM
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length < 2) return 0;
        var left = 0;
        var right = 1;
        var maxProfit=0;
        while(right < prices.Length){
            if(prices[left] < prices[right]){
                var profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit,profit);
            }
            else{
                left=right;
            }
            right++;
        }
        return maxProfit;
    }
}