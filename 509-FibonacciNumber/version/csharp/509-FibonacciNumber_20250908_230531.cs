// Last updated: 9/8/2025, 11:05:31 PM
public class Solution {
    public int Fib(int n) {
       if(n==0) return 0;
       if(n<2) return 1;
       return Fib(n-1)+Fib(n-2);
    }
}