using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //вхідні змінні
            int row = 0;
            int col = 0;

            //Змінні результатів
            int sumAll = 0;
            int sum = 0;
            int sumdial = 0;
            int rowSum = 0;
            int colSum = 0;

            Console.WriteLine();
            Console.Write("Введите количество строк: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество стовбцов: ");
            col = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] arr = new int[100, 100];
            
            int min = arr[0, 0];
            int max = arr[0, 0];

            int iii = row; // для обчислення зворотньої діагоналі

            Random r = new Random();

            //Створюємо масив
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j]= r.Next(5);
                }
            }

            //Виводимо в консоль масив
            for (int ii = 0; ii < row; ii++)
            {
                for(int jj = 0; jj < col; jj++)
                {
                    if (Math.Abs(arr[ii, jj]) <= 9)
                    {
                        Console.Write(" " + arr[ii, jj] + " ");
                    }
                    else
                    {
                        Console.Write(arr[ii, jj] + " ");
                    }
                }
                Console.WriteLine();
            }

            //Операції із масивом (сумування)
            for (int ii = 0; ii < row; ii++)
            {
                for (int jj = 0; jj < col; jj++)
                {
                    sumAll += arr[ii, jj];

                    //if (ii == jj)
                    //{
                    //    sum += arr[ii, jj];
                    //}

                    
                    if (max < arr[ii, jj])
                    {
                        max = arr[ii, jj];
                    }

                    if (min > arr[ii, jj])
                    {
                        min = arr[ii, jj];
                    }
                    
                    if (ii == 1)
                    {
                        rowSum += arr[ii, jj];
                    }
                    if (jj == 1)
                    {
                        colSum += arr[ii, jj];
                    }
                }

                if (ii < row && ii < col)
                {
                    sum += arr[ii, ii];
                }

                iii--;
                if (ii < row && iii < col)
                {
                    sumdial += arr[ii, iii];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Сума матрици: {0};", sumAll);
            Console.WriteLine("Сума дiагоналi: {0};", sum);
            Console.WriteLine("Сума протилежноi дiагоналi: {0};", sumdial);
            Console.WriteLine();
            Console.WriteLine("Max: {0};",max);
            Console.WriteLine("Min: {0};", min);
            Console.WriteLine("");
            Console.WriteLine("Сума 'I рядок': {0};", rowSum);
            Console.WriteLine("Сума 'II колонка': {0};", colSum);
            
            Console.Read();
        }
    }
}