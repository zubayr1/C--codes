using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 } };


            TranMat tranMat = new TranMat();

            var val = tranMat.TransposeMatrix(mat);

            

            var row1 = val.GetLength(0);
            var col1 = val.GetLength(1);

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.WriteLine(val[i, j]);
                }
            }

        }
    }

}
