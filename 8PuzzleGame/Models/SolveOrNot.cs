using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8PuzzleGame.Controllers
{
    class SolveOrNot
    {
        private int getInvCount(int[] array)
        {
            int count = 0;
            for (int i = 0; i < 9 - 1; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    if (array[j] != 0 && array[i] != 0 && array[i] > array[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public bool DAOUNAODA(int[,] puzzle)
        {
            int[] array1d = puzzle.Cast<int>().ToArray();

            int invCount = getInvCount(array1d);

            return (invCount % 2 == 0);
        }
    }
}