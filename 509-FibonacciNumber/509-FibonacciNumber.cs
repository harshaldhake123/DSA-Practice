// Last updated: 9/8/2025, 11:08:01 PM
public class Solution {
    public int Fib(int n) {
        // Using Recursion
       if(n==0) return 0;
       if(n<2) return 1;
       return Fib(n-1)+Fib(n-2);
    }

    public int FibIterative(int n) {
       if(n==0) return 0;
       if(n<2) return 1;
       var secondLast=0; //F(0)
       var last=1; //F(1)
       var current=0;
       for(int i=2;i<=n;i++){
            current=last+secondLast;
            secondLast=last;
            last=current;
       }
       return current;
    }
}