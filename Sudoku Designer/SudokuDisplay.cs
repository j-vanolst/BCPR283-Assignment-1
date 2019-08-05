using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    class SudokuDisplay : IDisplay
    {
        public void Get<T>(T message)
        {
            Console.WriteLine(message);
        }

        public void Reset(SudokuLevel theSudokuLevel, int size)
        {
            theSudokuLevel.SetSize(size);
        }

        public void Start()
        {
            Console.Clear();
        }

        public void Stop()
        {
            Console.WriteLine("Press enter to exit...");
            Console.ReadKey();
        }
    }
}
