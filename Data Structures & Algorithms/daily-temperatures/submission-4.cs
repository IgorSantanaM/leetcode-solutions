public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
       int[] res = new int[temperatures.Length];
       Stack<(int temperature, int index)> stack = new();
       int lastCount = temperatures[^1];

       for(int i = 0; i < temperatures.Length; i++)
       {

            while(stack.Count > 0 && stack.Peek().temperature < temperatures[i])
            {
                var pair = stack.Pop();
                res[pair.index] = i - pair.index; 
            }
            stack.Push((temperatures[i], i));
       }

       return res;
    }
}
