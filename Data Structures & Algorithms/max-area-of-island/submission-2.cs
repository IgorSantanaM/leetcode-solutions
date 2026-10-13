public class Solution {
    private readonly int[][] directions = new int[][]
    {
        new int[]{1, 0}, new int[]{-1, 0},
        new int[]{0, 1}, new int[]{0, -1}
    };

    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        int rows = grid.Length, cols = grid[0].Length;

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(grid[r][c] == 1)
                    maxArea = Math.Max(Bfs(grid, r, c), maxArea);
            }
        }

        return maxArea;
    }

    public int Bfs(int[][] grid, int r, int c)
    {
        int maxArea = 1;
        Queue<int[]> q = new();
        grid[r][c] = 0;
        q.Enqueue([r, c]);

        while(q.Count > 0)
        {
            var node = q.Dequeue();
            int row = node[0], col = node[1];

            foreach(var dir in directions)
            {
                int nr = row + dir[0], nc = col + dir[1];

                if(nr >= 0 && nc >= 0 && nr < grid.Length && nc < grid[0].Length && grid[nr][nc] == 1)
                {
                    q.Enqueue([nr, nc]);
                    grid[nr][nc] = 0;
                    maxArea++;
                }
            }
        }

        return maxArea;
    }
}
