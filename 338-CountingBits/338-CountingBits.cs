// Last updated: 9/16/2025, 9:39:56 PM
public class Solution {
    public int[] CountBits(int n) {
        var dp=new int[n+1];
        var offset=1;

        for(int i=1;i<=n;i++){
            if(i==offset*2){
                offset=i;
            }
            dp[i]=1+dp[i-offset];
        }
        return dp;
    }

    public int[] CountBitsBruteForce(int n) {
        // brute force O(nlogn_base2)
        var arr=new int[n+1];
        for(int i=0;i<=n;i++){
            var num=i;
            var count=0;
            while(num>0){
                var remainder = num%2;
                if(remainder==1){
                    count++;
                }
                num/=2;
            }
            arr[i]=count;
        }
        return arr;
    }
}