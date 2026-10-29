public class MinStack {
    private readonly Stack<(int value, int min)> _stack;
    public MinStack() {
        _stack = new();
    }
    
    public void Push(int val) {
       int currentMin = _stack.Count == 0 ? val : Math.Min(val, _stack.Peek().min);
       _stack.Push((val, currentMin)); 
    }
    
    public void Pop() {
      if(_stack.Count == 0)
        throw new ArgumentNullException("Stack is empty");
        _stack.Pop();
    }
    
    public int Top() {  
      if(_stack.Count == 0)
        throw new ArgumentNullException("Stack is empty");
      return _stack.Peek().value;
    }
    
    public int GetMin() {
       if(_stack.Count == 0)
        throw new ArgumentNullException("Stack is empty");

        return _stack.Peek().min;
    }
}
