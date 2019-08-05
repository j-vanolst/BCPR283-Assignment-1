using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    class SudokuController
    {
        protected SudokuLevel sudokuLevel;
        protected SudokuDisplay display;
        protected SudokuGet get;
        protected SudokuSet set;

        public void Go(SudokuLevel theSudokuLevel, SudokuDisplay theSudokuDisplay, SudokuGet theSudokuGet, SudokuSet theSudokuSet)
        {
            sudokuLevel = theSudokuLevel;
            display = theSudokuDisplay;
            get = theSudokuGet;
            set = theSudokuSet;

            display.Start();

            //Initial State of Sudoku Level
            sudokuLevel.SetSize(6);
            display.Get(sudokuLevel.Output());

            //Testing GetByRow, GetByCol and GetByCell
            display.Get(get.GetByCell(sudokuLevel, 1));
            display.Get(get.GetByRow(sudokuLevel, 0, 2));
            display.Get(get.GetByCol(sudokuLevel, 3, 0));

            //Testing SetByRow, SetByCol and SetByCell
            set.SetByCell(sudokuLevel, 1, 69);
            set.SetByRow(sudokuLevel, 0, 2, 420);
            set.SetByCol(sudokuLevel, 3, 0, 78);

            //Retesting GetByRow, GetByCol and GetByCell after changing values
            display.Get(sudokuLevel.Output());
            display.Get(get.GetByCell(sudokuLevel, 1));
            display.Get(get.GetByRow(sudokuLevel, 0, 2));
            display.Get(get.GetByCol(sudokuLevel, 3, 0));

            display.Stop();
        }
    }
}
