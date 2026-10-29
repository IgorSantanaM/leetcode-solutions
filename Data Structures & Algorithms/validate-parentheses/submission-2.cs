public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach(var c in s)
        {
            if(c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else
            {
                if(stack.Count == 0)
                    return false;
                var current = stack.Pop();
                if((c == ')' && current != '(') || (c == '}' && current != '{') || (c == ']' && current != '['))
                    return false;
            }
        }

        return stack.Count == 0;

    }
}
