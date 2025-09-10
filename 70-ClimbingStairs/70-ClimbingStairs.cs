// Last updated: 9/10/2025, 10:17:35 PM
/*
    [0]-> 0 ways
    [1]-> 1 ways
    [2]-> 2 ways
    [3]-> 3 ways
    [4]-> 5 ways
    [5]-> 8 ways
*/
public class Solution {
    //Recursive approach with memoization
    public int ClimbStairs(int n) {
        
        if(n==0) return 0;
        if(n==1) return 1;
        if(n==2) return 2;
        var map=new Dictionary<int,int>();
        map.Add(1,1);
        map.Add(2,2);
        return FibonacciMemory(n,map);
    }
    private int FibonacciMemory(int n, Dictionary<int,int> map){
        if(map.ContainsKey(n)) return map[n];
        map.Add(n, FibonacciMemory(n-1,map)+FibonacciMemory(n-2,map));
        return map[n];
    }
    
    //Recursive approach: TLE
    public int ClimbStairsRecursive(int n) {
        if(n==0) return 0;
        if(n==1) return 1;
        if(n==2) return 2;
        return ClimbStairsRecursive(n-1)+ClimbStairsRecursive(n-2);
    }

    //Iterative approach, no need of memoization because only last two values are in memory
    public int ClimbStairsIterative(int n) {
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