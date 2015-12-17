using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolverProject
{
    class SudokuSolver
    {
        private int[] grid;

        public SudokuSolver(String s)
        {
            grid = new int[81];
            for (int i = 0; i < s.Length; i++)
            {
                grid[i] = int.Parse(s[i].ToString());
            }
        }

        public void Solve()
        {
            try
            {
                PlaceNumber(0);
                Console.WriteLine("Cannot Solve");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(this);
            }
            //PlaceNumber(0);
        }

        public void PlaceNumber(int position)
        {
            if (position == 81)
            {
                throw new Exception("Solved");
                //Console.WriteLine("Solved");
            }
            if (grid[position] > 0)
            {
                PlaceNumber(position + 1);
                return;
            }
            for (int n = 1; n <= 9; n++)
            {
                if (CheckIfValid(n, position % 9, position / 9))
                {
                    grid[position] = n;
                    PlaceNumber(position + 1);
                    grid[position] = 0;
                }
            }
        }

        public bool CheckIfValid(int val, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[y * 9 + i] == val || grid[i * 9 + x] == val)
                    return false;
            }
            int startX = (x / 3) * 3;
            int startY = (y / 3) * 3;
            for (int i = startY; i < startY + 3; i++)
            {
                for (int j = startX; j < startX + 3; j++)
                {
                    if (grid[i * 9 + j] == val)
                        return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string sb = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sb += (grid[i * 9 + j] + " ");
                    //if (j == 2 || j == 5) ;
                        //sb += ("| ");
                        //sb += ("");
                }
                sb += ('\n');
                //if (i == 2 || i == 5)
                //    sb += ("------+-------+------\n");
            }
            return sb;
        }

    }
}
