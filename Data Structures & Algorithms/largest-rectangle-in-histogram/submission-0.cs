public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int largestArea = 0;
        Stack<(int index, int height)> stack = new();

        for(int i = 0; i < heights.Length; i++)
        {
            int start = i;
            while(stack.Count > 0 && stack.Peek().height > heights[i])
            {
                var pair = stack.Pop();

                var width = i - pair.index;

                int area = pair.height * width;

                largestArea = Math.Max(area, largestArea);
                start = pair.index;
            }

            stack.Push((start, heights[i]));
        }

        foreach(var pair in stack)
        {
            int index = pair.index;
            int height = pair.height;
            largestArea = Math.Max(largestArea, height * (heights.Length - index));
        }

        
        return largestArea;
    }
}
