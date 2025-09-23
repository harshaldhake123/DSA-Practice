// Last updated: 9/23/2025, 9:18:37 PM
public class Solution {
    public int CompareVersion(string version1, string version2) {
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