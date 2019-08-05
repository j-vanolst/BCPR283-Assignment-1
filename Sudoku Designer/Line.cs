using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    class Line
    {
        protected int size;
        protected Cell[] lineNumbers;

        public void SetSize(int newSize)
        {
            size = newSize;
            lineNumbers = new Cell[size];
        }
        public void SetCell(int offset, Cell theCell)
        {
            lineNumbers[offset] = theCell;
        }
        public Cell GetCell(int offset)
        {
            return lineNumbers[offset];
        }
        public string Output()
        {
            string output = "";
            foreach(Cell cell in lineNumbers)
            {
                output += cell.GetCell() + "\t";
            }
            return output;
        }
    }
}
