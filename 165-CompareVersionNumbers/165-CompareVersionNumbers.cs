// Last updated: 9/23/2025, 9:38:18 PM
public class Solution {
    // TC: O(N)
    // SC: O(1)
    public int CompareVersion(string version1, string version2) {
        var i=0;
        var j=0;
        while(i<version1.Length || j<version2.Length){
            var num1=0;
            var num2=0;
            while(i<version1.Length && version1[i]!='.'){
                num1=num1*10 + version1[i]-'0';
                i++;
            }
            while(j<version2.Length && version2[j]!='.'){
                num2=num2*10 + version2[j]-'0';
                j++;
            }
            if(num1 < num2){
                return -1;
            }else if(num1 >num2){
                return 1;
            }
            i++;
            j++;
        }
        return 0;
    }

    //TC: O(max(v1.Length,v2.Length))= O(N)
    //SC: O(n) due to two new arrays 
    public int CompareVersionUsingSplit(string version1, string version2) {
        var versions1=version1.Split('.');
        var versions2=version2.Split('.');
        var length=Math.Max(versions1.Length,versions2.Length);

        for(int i=0;i<length;i++){
            var i1= i< versions1.Length? int.Parse(versions1[i]):0;
            var i2= i< versions2.Length? int.Parse(versions2[i]):0;
            if(i1<i2){
                return -1;
            }else if(i1 > i2){
                return 1;
            }
        }
        return 0;
    }
}