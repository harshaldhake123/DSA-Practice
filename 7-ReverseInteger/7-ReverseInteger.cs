// Last updated: 12/2/2025, 10:21:00 PM
1public class Solution {
2    public int Reverse(int x) {
3        var isNegative=false;
4        var result=0;
5        if(x<0){
6            isNegative=true;
7            x*=-1;
8        }
9        while(x>0){
10            var remainder=x%10;
11            if(result>(int.MaxValue-remainder)/10){
12                return 0;
13            }
14            result=result*10+remainder;
15            x=x/10;
16        }
17        return isNegative? -result : result;
18    }
19}