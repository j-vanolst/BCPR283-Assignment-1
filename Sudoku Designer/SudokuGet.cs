using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    class SudokuGet : IGet
    {
        public void GetByBox(SudokuLevel theSudokuLevel, int boxNum, int offset)
        {
            throw new NotImplementedException();
        }

        public int GetByCell(SudokuLevel theSudokuLevel, int cellNum)
        {
            Cell theCell = theSudokuLevel.GetByCell(cellNum);
            return theCell.GetCell();
        }

        public int GetByCol(SudokuLevel theSudokuLevel, int colNum, int offset)
        {
            Cell theCell = theSudokuLevel.GetByCol(colNum, offset);
            return theCell.GetCell();
        }

        public int GetByRow(SudokuLevel theSudokuLevel, int rowNum, int offset)
        {
            Cell theCell = theSudokuLevel.GetByRow(rowNum, offset);
            return theCell.GetCell();
        }
    }
}
