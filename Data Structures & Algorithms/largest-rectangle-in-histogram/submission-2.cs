public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;
        Stack<int[]> stack = new();

        for(int i = 0; i < heights.Length; i++)
        {
            int start = i;
            while(stack.Count > 0 && stack.Peek()[1] > heights[i])
            {
                var pair = stack.Pop();
                int index = pair[0];
                int height = pair[1];
                
                int localArea = (i - index) * height;
                maxArea = Math.Max(localArea, maxArea);
                start = index;
            }

            stack.Push(new int[] {start, heights[i]});
        }

        foreach(var pair in stack)
        {
            int index = pair[0];
            int height = pair[1];
            int localArea = ( heights.Length - index) * height;
            maxArea = Math.Max(localArea, maxArea);
        }

        return maxArea;

    }
}
