// Last updated: 10/3/2025, 9:21:03 PM
public class MinStack {
    private readonly Stack<int> stack;
    private readonly Stack<int> minStack; // this will store the min value in the actual stack, corresponding to the current stack's top position.
    public MinStack() {
        stack=new Stack<int>();
        minStack=new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);    
        if(minStack.Count>0){
            val=Math.Min(val, minStack.Peek());
        }
        minStack.Push(val);
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
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