// Last updated: 9/10/2025, 9:58:02 PM
public class Solution {
    private Dictionary<int,int> map = new Dictionary<int,int>();
    public int ClimbStairs(int n) {
        /*
        [2]: 2 steps
        [3]: 3 steps
        [4]: 5 steps
        [5]: 8 steps
        [6]: 13 steps.
        which means, f(n)=f(n-1)+f(n-2)
        */
        if(n<=0) return 0;
        map.TryAdd(1,1);
        map.TryAdd(2,2);
        int result=0;
       if(map.ContainsKey(n)){
            return map[n];
       }
       var a = ClimbStairs(n-1);
       map[n-1]=a;
       var b = ClimbStairs(n-2);
       map[n-2]=b;
       return a+b;
    }
}