// Last updated: 9/9/2025, 9:42:33 PM
public class Solution {

    public int MaxProfit(int[] prices) {
        if(prices.Length<2){ return 0;}
        var left=0;
        var right=1;
        var maxProfit=0;

        while(right < prices.Length){
            if(prices[left]>prices[right]){
                left=right;
            }else{
                maxProfit=Math.Max(prices[right]-prices[left],maxProfit);
            }
            right++;
        }
        return maxProfit;
    }
   
    //TLE
    public int MaxProfitBruteForce(int[] prices) {
        var maxProfit=0;
        for(int i=0;i<prices.Length-1;i++){
            var buy=prices[i];
            for(int j=i+1;j<prices.Length;j++){
                var sell=prices[j];
                var profit=sell-buy;
                maxProfit=Math.Max(maxProfit,profit);
            }
        }
        return maxProfit;
    }
}