using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    interface IDisplay
    {
        void Start();
        //Resets the Sudoku to all 0's
        void Reset(SudokuLevel theSudokulevel, int size);
        //Draws the Sudoku
        void Get<T>(T message);
        void Stop();
    }
}
