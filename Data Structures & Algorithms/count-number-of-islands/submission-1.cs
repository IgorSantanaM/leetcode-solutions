public class Solution {
    private readonly int[][] directions = new int[][]
    {
        new int[]{1, 0}, new int[]{-1, 0},
        new int[]{0, 1}, new int[]{0, -1}
    };

    public int NumIslands(char[][] grid) {
        int ROWS = grid.Length;
        int COLS = grid[0].Length;
        int result = 0;

        for(int r = 0; r < ROWS; r++)
        {
            for(int c = 0; c < COLS; c++)
            {
                if(grid[r][c] == '1')
                {
                    Bfs(grid, r, c);
                    result++;
                }
            }
        }
        return result;
    }

    private void Bfs(char[][] grid, int r, int c)
    {
        var q = new Queue<int[]>();
        grid[r][c] = '0';
        q.Enqueue([r, c]);

        while(q.Count > 0)
        {
            var node = q.Dequeue();
            var cr = node[0];
            var cc = node[1];

            foreach(var dir in directions)
            {
                var rn = (cr + dir[0]);
                var cn = (cc + dir[1]);

                if(rn >= 0 && cn >= 0 && rn < grid.Length && cn < grid[0].Length && grid[rn][cn] == '1')
                {
                    q.Enqueue([rn, cn]);
                    grid[rn][cn] = '0';
                }
            }
        }
    }
}
