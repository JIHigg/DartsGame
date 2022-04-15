using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartsGame
{
    public class Dartboard
    {
        private int[] board = new int[] { 20, 1, 18, 4, 13, 6, 10, 15, 2, 17, 3, 19, 7, 16, 8, 11, 14, 9, 12, 5 };

        /// <summary>
        /// Determines accuracy of Player shot and returns point value
        /// </summary>
        /// <param name="aimTarget"></param>
        /// <returns></returns>
        public int Target(int aimTarget)
        {
            int chance = new Random().Next(1, 100);
            int target = GetTarget(aimTarget);

            int actual = 0;
            switch (chance)
            {
                case int n when n <= 100 && n > 95:
                    int q = new Random().Next(1, 20);
                    actual = board[q];
                    break;

                case int n when n <= 95 && n > 90:
                    break;

                case int n when n <= 90 && n > 75:
                    if (target + 1 < board.Length)
                    {
                        actual = board[target + 1];
                    }
                    else actual = board[0];
                    break;

                case int n when n <= 75 && n > 60:
                    if (target - 1 < 0)
                    {
                        actual = board[19];
                    }
                    else actual = board[target - 1];
                    break;

                case int n when n <= 60:
                    actual = board[target];
                    break;
            }

            return actual;
        }


        /// <summary>
        /// Returns index of target number on dartboard
        /// </summary>
        /// <param name="aimTarget"></param>
        /// <returns></returns>
        private int GetTarget(int aimTarget)
        {
            int result = -1;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == aimTarget) result = i;
            }
            return result;
        }
    }
}
