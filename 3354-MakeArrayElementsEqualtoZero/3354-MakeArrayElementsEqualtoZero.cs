// Last updated: 10/28/2025, 10:46:47 PM
public class Solution {
    public int TotalMoney(int n) {
        var ans=0;
        var monday=1;

        while(n>0){
            for(int day=0;day<Math.Min(n,7);day++){
                ans=ans+monday+day;
            }
            n=n-7;
            monday++;
        }
        return ans;
    }
}