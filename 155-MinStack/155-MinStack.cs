// Last updated: 10/3/2025, 9:13:25 PM
public class MinStack {
    private readonly Stack<int> stack;
    
    public MinStack() {
        stack=new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);    
    }
    
    public void Pop() {
        if(stack.Count>0)
            stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        var temp=new Stack<int>();
        var min=stack.Peek();
        while(stack.Count>0){
            var top = stack.Pop();
            temp.Push(top);
            min=Math.Min(min,top);
        }
        while(temp.Count>0){
            stack.Push(temp.Pop());
        }
        return min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */