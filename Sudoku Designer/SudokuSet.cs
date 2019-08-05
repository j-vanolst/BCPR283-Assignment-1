using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    class SudokuSet : ISet
    {
        public void SetByBox(SudokuLevel theSudokuLevel, int boxNum, int offset, int newValue)
        {
            throw new NotImplementedException();
        }

        public void SetByCell(SudokuLevel theSudokuLevel, int cellNum, int newValue)
        {
            theSudokuLevel.SetByCell(cellNum, newValue);
        }

        public void SetByCol(SudokuLevel theSudokuLevel, int colNum, int offset, int newValue)
        {
            theSudokuLevel.SetByCol(colNum, offset, newValue);
        }

        public void SetByRow(SudokuLevel theSudokuLevel, int rowNum, int offset, int newValue)
        {
            theSudokuLevel.SetByRow(rowNum, offset, newValue);
        }
    }
}
