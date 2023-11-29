﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20_workingWithSpecificStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 100;
            int[,] mainArray = new int[5, 4];
            int selectedRowNumber = 2;
            int selectedColumnNumber = 1;
            int summSelectedRow = 0;
            int multiplySelectedColumn = 0;

            for (int i = 0; i < mainArray.GetLength(0); i++)
            {
                for (int j = 0; j < mainArray.GetLength(1); j++)
                {
                    mainArray[i, j] = random.Next(minNumber, maxNumber + 1);
                    Console.Write(mainArray[i, j] + " ");

                    if (i == selectedRowNumber - 1)
                        summSelectedRow += mainArray[i, j];

                    if (j == selectedColumnNumber - 1)
                    {
                        if (multiplySelectedColumn == 0)
                        {
                            multiplySelectedColumn = mainArray[i, j];
                            continue;
                        }

                        multiplySelectedColumn *= mainArray[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nСумма {selectedRowNumber} строки, равна {summSelectedRow}.");
            Console.WriteLine($"Произведение {selectedColumnNumber} столбца, равно {multiplySelectedColumn}.");
        }
    }
}
