// Last updated: 10/14/2025, 9:43:27 PM
public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));
        var merged=new List<int[]>();
        var previous=intervals[0];//first element to be compared
        for(var i=1;i<intervals.Length;i++){
            var current=intervals[i];
            if(current[0]<=previous[1]){
                previous[1]=Math.Max(current[1],previous[1]);
            }else{
                merged.Add(previous);
                previous=current;
            }
        }
        merged.Add(previous);
        return merged.ToArray();
    }
}