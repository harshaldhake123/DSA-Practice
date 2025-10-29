// Last updated: 10/29/2025, 11:01:36 PM
public class Solution {
    public int SmallestNumber(int n) {
        // only 2^n-1 numbers have all set bits
        //so one approach is to find smallest number greater than n that is equal to 2^n-1

        var i=0;
        while(Math.Pow(2,i)-1<n){
            i++;
        }
        return (int)Math.Pow(2,i)-1;
    }
}