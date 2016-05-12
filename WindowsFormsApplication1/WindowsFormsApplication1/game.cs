using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class game
    {
        int move;
        int[,] grid = new int[3, 3];
        public game()
        {
            move = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = -10;
                }
            }
        }
        public int which_player()
        {
            return (move-1) % 2;
        }
        public bool Set_move(int x, int y)
        {
            if (grid[x, y] >= 0) return false;
            grid[x, y] = (move % 2)+1;
            move++;
            return true;
        }
        public bool is_drow()
        {
            return move >= 9;
        }
        public int is_win()
        {
            int sum = grid[0, 0] + grid[0, 1] + grid[0, 2];
            if (sum == 3 || sum == 6)
            {
                return sum / 3;
            }
            sum = grid[1, 0] + grid[1, 1] + grid[1, 2];
            if (sum == 3 || sum == 6)
            {
                return sum / 3;
            }
            sum = grid[2, 0] + grid[2, 1] + grid[2, 2];
            if (sum == 3 || sum == 6)
            {
                return sum / 3;
            }
            sum = grid[0, 0] + grid[1, 0] + grid[2, 0];
            if (sum == 3 || sum == 6)
            {
                return sum / 3;
            }
            sum = grid[0, 1] + grid[1, 1] + grid[2, 1];
            if (sum == 3 || sum == 6)
            {
                return sum / 3;
            }
            sum = grid[0, 2] + grid[1, 2] + grid[2, 2];
            if (sum == 6 || sum == 3)
            {
                return sum / 3;
            }
            sum = grid[0, 0] + grid[1, 1] + grid[2, 2];
            if (sum == 6 || sum == 3)
            {
                return sum / 3;
            }
            sum = grid[0, 2] + grid[1, 1] + grid[2, 0];
            if (sum == 6 || sum == 3)
            {
                return sum / 3;
            }
            return sum;
        }
    }
}
