// Last updated: 9/10/2025, 10:09:46 PM
public class Solution {
    public int ClimbStairs(int n) {
        /*
        [0]-> 0 ways
        [1]-> 1 ways
        [2]-> 2 ways
        [3]-> 3 ways
        [4]-> 5 ways
        [5]-> 8 ways
        */
        if(n==0) return 0;
        if(n==1) return 1;
        if(n==2) return 2;
        var a=1;
        var b=1;
        var steps=0;
        var c=0;
        for(int i=2;i<=n;i++){
            c=a+b;
            a=b;
            b=c;
        }
        return c;
    }

}