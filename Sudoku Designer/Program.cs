using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    class Program
    {
        static void Main(string[] args)
        {
            new SudokuController().Go(new SudokuLevel(), new SudokuDisplay(), new SudokuGet(), new SudokuSet());
        }
    }
}
