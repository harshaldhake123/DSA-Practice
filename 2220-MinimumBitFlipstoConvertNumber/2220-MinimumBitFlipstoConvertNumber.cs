// Last updated: 9/30/2025, 11:41:19 PM
public class Solution {
    public int MinBitFlips(int start, int goal) {
     var result=start^goal;
        var n=result;
        var count=0;
        while(n>0){
            var rem=n%2;
            n/=2;
            if(rem==1){
                count++;
            }
        }
        return count;
    }
}