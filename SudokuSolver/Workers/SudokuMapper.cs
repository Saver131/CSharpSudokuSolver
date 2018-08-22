using SudokuSolver.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Workers
{
    class SudokuMapper
    {
        public SudokuMap Find(int givenRow, int givenCol)
        {
            SudokuMap sudokuMap = new SudokuMap();

            if ((givenRow >= 0 && givenRow <= 2) && (givenCol >= 0 && givenCol <= 2))
            {
                sudokuMap.StartRow = 0;
                sudokuMap.StartCol = 0;
            }

            else if ((givenRow >= 0 && givenRow <= 2) && (givenCol >= 3 && givenCol <= 5))
            {
                sudokuMap.StartRow = 0;
                sudokuMap.StartCol = 3;
            }

            else if ((givenRow >= 0 && givenRow <= 2) && (givenCol >= 6 && givenCol <= 8))
            {
                sudokuMap.StartRow = 0;
                sudokuMap.StartCol = 6;
            }

            return sudokuMap;
        }
    }
}
