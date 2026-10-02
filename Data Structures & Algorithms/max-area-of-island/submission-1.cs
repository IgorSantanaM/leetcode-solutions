public class Solution {
    private static readonly int[][] directions = new int[][] {
        new int[] { 1, 0 }, new int[]{-1, 0},
        new int[] { 0, 1 },  new int[]{0, -1}
    };
    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        int rows = grid.Length, cols = grid[0].Length;
        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                int currentArea = 0;
                if(grid[r][c] == 1)
                {
                    currentArea = Bfs(grid, r, c);
                }

                maxArea = Math.Max(currentArea, maxArea);
            }
        }

        return maxArea;
    }

    public int Bfs(int[][] grid, int r, int c)
    {
        int currentArea = 1;
        Queue<int[]> q = new();
        grid[r][c] = 0;

        q.Enqueue([r, c]);

        while(q.Count > 0)
        {
            var nodes = q.Dequeue();
            int cr = nodes[0], cc = nodes[1];
            foreach(var dir in directions)
            {
                int rn = cr + dir[0], cn = cc + dir[1];
                if(rn >= 0 && cn >= 0 && rn < grid.Length && cn < grid[0].Length && grid[rn][cn] == 1)
                {
                    currentArea++;
                    grid[rn][cn] = 0;
                    q.Enqueue([rn, cn]);
                }
            }
        }

        return currentArea;
    }
}
