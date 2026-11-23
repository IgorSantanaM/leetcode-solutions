public class Solution {
    private static int[][] directions = new int[][]
    {
        new int[]{1, 0}, new int[]{0, 1},
        new int[]{-1, 0}, new int[]{0, -1}
    };
    public int NumIslands(char[][] grid) {
        var ROWS = grid.Length;
        var COLS = grid[0].Length;
        int result = 0;
        for(int r = 0; r < ROWS; r++)
        {
            for(int c = 0; c < COLS; c++)
            {
                if(grid[r][c] == '1')
                {
                    Bfs(r, c, grid);
                    result++;
                }
            }
        }

        return result;  
    }

    private void Bfs(int row, int column, char[][] grid)
    {
        var q = new Queue<int[]>();
        grid[row][column] = '0';
        q.Enqueue([row, column]);

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
