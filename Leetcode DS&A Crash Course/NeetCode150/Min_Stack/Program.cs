//Min Stacck
// Time Complexity: O(1)
// Space Complexity: O(n)

public class MinStack {
    private Stack <int> stack = new(); 
    private Stack <int> min = new();

    public MinStack() {}
    
    public void Push(int val) {
        stack.Push(val);
        if(min.Count == 0 || val <= min.Peek()) min.Push(val);
    }
    
    public void Pop() {
        int stackTop = stack.Peek();
        stack.Pop(); 
        if (stackTop == min.Peek()) min.Pop(); 
    }
    
    public int Top() {
        return stack.Peek(); 
    }
    
    public int GetMin() {
        return min.Peek(); 
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