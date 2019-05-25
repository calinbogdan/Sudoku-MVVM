using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Model.Grid
{
    public class GridModel
    {
        private readonly Slot[,] _slots = new Slot[9, 9];

        public Slot SlotAt(Vector2 vector)
        {
            return _slots[vector.X, vector.Y];
        }

        public Slot SlotAt(int x, int y)
        {
            return _slots[x, y];
        }
    }
}
