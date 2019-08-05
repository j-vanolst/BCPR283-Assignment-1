using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    interface IGet
    {
        int GetByCell(SudokuLevel theSudokoLevel, int cellNum);
        int GetByRow(SudokuLevel theSudokoLevel, int rowNum, int offset);
        int GetByCol(SudokuLevel theSudokoLevel, int colNum, int offset);
        void GetByBox(SudokuLevel theSudokoLevel, int boxNum, int offset);
    }
}
