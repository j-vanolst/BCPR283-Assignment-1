using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    interface ISet
    {
        void SetByCell(SudokuLevel theSudokuLevel, int cellNum, int newValue);
        void SetByRow(SudokuLevel theSudokuLevel, int rowNum, int offset, int newValue);
        void SetByCol(SudokuLevel theSudokuLevel, int colNum, int offset, int newValue);
        void SetByBox(SudokuLevel theSudokuLevel, int boxNum, int offset, int newValue);
    }
}
