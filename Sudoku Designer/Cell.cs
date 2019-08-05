using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    class Cell
    {
        protected int value;

        public void SetCell(int newValue)
        {
            value = newValue;
        }
        public int GetCell()
        {
            return value;
        }
    }
}
