using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TranMat
    {
        public int[,] TransposeMatrix(int[,] matrix)
        {
            // Write your code here.

            var row1 = matrix.GetLength(0);
            var col1 = matrix.GetLength(1);

            int[,] transposed = new int[col1, row1];


            for(int i=0; i<row1; i++)
            {
                for(int j=0; j<col1; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            return transposed ;
        }
    }
}
