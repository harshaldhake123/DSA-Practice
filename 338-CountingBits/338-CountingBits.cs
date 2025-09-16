// Last updated: 9/16/2025, 9:09:33 PM
public class Solution {
    public int[] CountBits(int n) {
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