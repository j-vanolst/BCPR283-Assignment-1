using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Designer
{
    class SudokuLevel
    {
        protected int size;
        protected Cell[] cells;
        public Line[] rows;
        public Line[] cols;
        public Box[] boxes;

        public void SetSize(int newSize)
        {
            size = newSize;
            cells = new Cell[size * size];
            GenerateCells();
            GenerateRows();
            GenerateCols();
        }

        void GenerateCells()
        {
            for(int i = 0; i < (size * size); i++)
            {
                cells[i] = new Cell();
                cells[i].SetCell(0);
            }
        }

        void GenerateRows()
        {
            rows = new Line[size];
            //Creates a new Line Object for each row
            for(int i = 0; i < size; i++)
            {
                rows[i] = new Line();
                rows[i].SetSize(size);
            }
            //Finds the rows and sets the relevant cells
            int rowCount = 0;
            for (int i = 0; i < cells.Length; i++)
            {
                if (i == 0)
                {
                    rows[rowCount].SetCell(i % size, cells[i]);
                }
                else if (i % size == 0)
                {
                    rowCount += 1;
                    rows[rowCount].SetCell(i % size, cells[i]);
                }
                else
                {
                    rows[rowCount].SetCell(i % size, cells[i]);
                }
            }
        }

        void GenerateCols()
        {
            cols = new Line[size];
            //Generates a new line object for each column
            for(int i = 0; i < size; i++)
            {
                cols[i] = new Line();
                cols[i].SetSize(size);
            }
            //Sets each cell to the correct column and position
            int rowCount = 0;
            for (int i = 0; i < cells.Length; i++)
            {
                if (i == 0)
                {
                    cols[i % size].SetCell(rowCount, cells[i]);
                }
                else if (i % size == 0)
                {
                    rowCount += 1;
                    cols[i % size].SetCell(rowCount, cells[i]);
                }
                else
                {
                    cols[i % size].SetCell(rowCount, cells[i]);
                }
            }
        }

        public void SetByCell(int cellNum, int newNum)
        {
            Cell theCell = GetByCell(cellNum);
            theCell.SetCell(newNum);
        }

        public void SetByRow(int rowNum, int offset, int newNum)
        {
            Cell theCell = GetByRow(rowNum, offset);
            theCell.SetCell(newNum);
        }

        public void SetByCol(int colNum, int offset, int newNum)
        {
            Cell theCell = GetByCol(colNum, offset);
            theCell.SetCell(newNum);
        }

        public Cell GetByCell(int cellNum)
        {
            Cell theCell = cells[cellNum];
            return theCell;
        }

        public Cell GetByRow(int rowNum, int offset)
        {
            Cell theCell = rows[rowNum].GetCell(offset);
            return theCell;
        }

        public Cell GetByCol(int colNum, int offset)
        {
            Cell theCell = cols[colNum].GetCell(offset);
            return theCell;
        }

        public string Output()
        {
            string output = "";

            for(int i = 0; i < cells.Length; i++)
            {
                if(i % size == 0)
                {
                    output += "\n";
                }
                output += cells[i].GetCell() + "\t";
            }

            return output;
        }
    }
}
