using System;
using System.Linq;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 3, 4 , 1}, { 5, 6 , 9} };

            int rowsNum = matrix.GetLength(0);
            int colsNum = matrix.GetLength(1);

            //print normal matrix
            while(x < rowsNum)
            {
                y = 0;
                while (y < colsNum) 
                {
                    Console.Write(matrix[x, y]);
                    Console.Write(" ");
                    y++;
                    if (y == colsNum)
                    {
                        Console.WriteLine("");
                    }
                }
            x++;
            }


            //print transpusa
            Console.WriteLine("Transpusa e: ");
            x = 0;
            y = 0;

            colsNum = colsNum - 1;

            while (x < rowsNum && colsNum >= 0)
            {
                Console.Write(matrix[x, colsNum]);
                Console.Write(" ");
                colsNum--;
                x++;
            }
        }
    }
}
