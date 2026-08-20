public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
       var pairs = new int[position.Length][];

       for(int i = 0; i < position.Length; i++)
       {
            pairs[i] = new int[]{position[i], speed[i]};
       }

        Array.Sort(pairs, (a, b) =>
            b[0].CompareTo(a[0]));

       Stack<double> stack = new();
    
        foreach(var pair in pairs)
        {
            stack.Push((double)(target - pair[0]) / pair[1]);

            if(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
                stack.Pop();
        }

        return stack.Count;


    }
}
