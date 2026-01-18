// Last updated: 1/18/2026, 2:35:51 PM
1public class Solution {
2    public int LongestConsecutive(int[] nums) {
3        var maxCount=0;
4        var set=new HashSet<int>();
5        foreach(var n in nums){
6            set.Add(n);
7        }
8        foreach(var num in set){
9            var n=num;
10            if(!set.Contains(n-1)){ // its a new sequence
11                var count=1;
12                while(set.Contains(n+1)){
13                    n++;
14                    count++;
15                }
16                maxCount=Math.Max(maxCount,count);
17            }
18        }
19        return maxCount;
20    }
21
22    // Sorting array
23     public int LongestConsecutiveSorting(int[] nums) {
24        if(nums.Length==0){
25            return 0;
26        }
27        var maxCount=1;
28        var count=1;
29        Array.Sort(nums);
30        for(int i=1;i<nums.Length;i++){
31            if(nums[i-1]==nums[i]){ //skip if duplicate
32                continue;
33            }
34            if(nums[i]==nums[i-1]+1){ // current is consecutive to last
35                count++;
36            }else { 
37                // sequence broke, so reset count, find max until now
38                maxCount=Math.Max(maxCount,count);
39                count=1;
40            }
41        }
42        return Math.Max(maxCount,count);;
43    }
44
45public int LongestConsecutiveBruteForce(int[] nums) {
46        var maxCount=0;
47        foreach(var n in nums){
48            var count=1;
49            var num=n;
50            //while we find next consecutive elements, keep incrementing count.
51            //if we don't find, then break the loop and check next number
52            while(Search(nums,num+1)){
53                num++;
54                count++;
55            }
56            maxCount=Math.Max(count,maxCount);
57        }
58        return maxCount;
59    }
60
61
62    private bool Search(int[] nums,int k){
63        foreach(var n in nums){
64            if(n==k){
65                return true;
66            }
67        }
68        return false;
69    }
70}