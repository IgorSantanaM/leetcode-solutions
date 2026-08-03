public class MinStack {
    private readonly List<(int Value, int Min)> _stack;
    public MinStack() {
        _stack = new();
    }
    
    public void Push(int val) {
        int currentMin = _stack.Count == 0 
        ? val 
        : Math.Min(val, _stack[^1].Min);
        _stack.Add((val, currentMin));
    }
    
    public void Pop() {
        if(_stack.Count == 0)
            throw new InvalidOperationException("The stack is empty");

        _stack.RemoveAt(_stack.Count - 1);
    }
    
    public int Top() {  
        if(_stack.Count == 0)
           throw new InvalidOperationException("The stack is empty");      
        return _stack[^1].Value;

    }
    
    public int GetMin() {
        if(_stack.Count == 0)
            throw new InvalidOperationException("The stack is empty"); 
        return _stack[^1].Min;
    }
}
