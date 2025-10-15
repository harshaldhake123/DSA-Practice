// Last updated: 10/15/2025, 10:24:44 PM
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var res = new int[temperatures.Length];
        var stack = new Stack<int>();//stack will contain indices of days waiting for their next warm day;
        for(int i=0;i<temperatures.Length;i++){
            var current=temperatures[i];
            while(stack.Count>0 && current > temperatures[stack.Peek()]){
                var previousDay = stack.Pop();
                res[previousDay]=i-previousDay;
            }
            stack.Push(i);
        }
        return res;
    }
    // O(n2)
    public int[] DailyTemperaturesBruteForce(int[] temperatures) {
        var arr=new int[temperatures.Length];
        for(int i=0;i<temperatures.Length-1;i++){
            var current=temperatures[i];
            var days=0;
            for(int j=i+1;j<temperatures.Length;j++){
                var next=temperatures[j];
                if(j==temperatures.Length){
                    arr[i]=0;
                    break;
                }
                if(next > current){
                    arr[i]=(++days);
                    break;
                }
                days++;
            }
        }
        return arr;
    }
}