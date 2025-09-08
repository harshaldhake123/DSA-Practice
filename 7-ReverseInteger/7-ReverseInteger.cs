// Last updated: 9/8/2025, 11:08:47 PM
public class Solution {
    public int Reverse(int x) {
        var isNegative=false;
        if(x<0){
            isNegative=true;
            x=-x;
        }
        int res=0;

        while(x>0){
            var rem=x % 10;
            if(res > (int.MaxValue-rem)/10){
                return 0;
            }
            res=res*10 + rem;
            x/=10;
        }
        if(isNegative){
            return -res;
        }
        return res;
    }
}