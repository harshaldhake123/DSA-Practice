// Last updated: 10/7/2025, 9:52:33 PM
public class Solution {
    public int MyAtoi(string s) {
        if(string.IsNullOrWhiteSpace(s)) return 0;
        var result=0;
        var sign=1;
        var i=0;
        //Rule 1: ignore leading whitespaces
        while(i<s.Length && s[i]==' '){
            i++;
        }
        //Rule 2: determine sign
        if(i<s.Length && s[i]=='-' ||s[i]=='+'){
            sign= s[i]=='-'?-1 : 1;
            i++;
        }
        //Rule 3: Skip leading zeroes
        while(i<s.Length && s[i]=='0'){
            i++;
        }
        //Rule 4: Roundoff long to max/min int if overflow
        while(i<s.Length && char.IsDigit(s[i])){
            var digit=s[i]-'0';
            if(result > int.MaxValue/10 || (result==int.MaxValue/10 && digit>7)){
                return sign>0? int.MaxValue: int.MinValue;
            }
            result=result*10+digit;
            i++;
        }
        return sign*result;
    }
}