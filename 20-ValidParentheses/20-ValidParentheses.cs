// Last updated: 9/15/2025, 11:06:58 PM
public class Solution {
    public bool IsValid(string s) {
        var stack=new Stack<char>();
        var openings=new List<char>(){'(','[','{'};

        foreach(var c in s){
            if(openings.Contains(c)){
                stack.Push(c);
            } else {
                if(stack.Count==0) return false;
                
                var top=stack.Peek();
                if( top=='(' && c==')' ||
                    top=='[' && c==']' ||
                    top=='{' && c=='}'
                ){
                    stack.Pop();
                }else{
                    return false;
                }
            }
        }
        return stack.Count==0;
    }
}