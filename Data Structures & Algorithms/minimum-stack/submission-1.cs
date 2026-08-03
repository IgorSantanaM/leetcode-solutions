public class MinStack {
    private readonly Stack<(int Value, int Min)> _stack;
    public MinStack() {
        _stack = new();
    }
    
    public void Push(int val) {
        int currentMin = _stack.Count == 0 
        ? val 
        : Math.Min(val, _stack.Peek().Min);
        _stack.Push((val, currentMin));
    }
    
    public void Pop() {
        if(_stack.Count == 0)
            throw new InvalidOperationException("The stack is empty");

        _stack.Pop();
    }
    
    public int Top() {  
        if(_stack.Count == 0)
           throw new InvalidOperationException("The stack is empty");      
        return _stack.Peek().Value;

    }
    
    public int GetMin() {
        if(_stack.Count == 0)
            throw new InvalidOperationException("The stack is empty"); 
        return _stack.Peek().Min;
    }
}
