public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] res = new int[n];
        Stack<(int temperature, int index)> stack = new();
        int lastCount = temperatures[^1];

        for(int i = 0; i < n; i++)
        {
            if(i == lastCount)
                res[i] = 0;

            var t = temperatures[i];

            while(stack.Count > 0 && t > stack.Peek().temperature)
            {
                var pair = stack.Pop();
                res[pair.index] = i - pair.index;
            }
            stack.Push((t,i));
        }

        return res;
    }
}
