// Last updated: 10/1/2025, 10:05:39 PM
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        var low=1;
        var high=n;
        while(low < high){
            var mid=low+(high-low)/2;
            if(this.IsBadVersion(mid)){
                high=mid;
            }else{
                low=mid+1;
            }
        }
        return low;
    }
}