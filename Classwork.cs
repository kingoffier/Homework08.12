using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Massiv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = File.ReadAllLines("input.txt");
            //int row = lines.Length; int col = lines[0].Split(';').Length;
            //int[,] table = new int[row, col];
            //// Заполнение таблицы и вывод на консоль            Console.WriteLine("Первый массив");
            //for (int i = 0; i < row; i++)
            //{
            //    string[] values = lines[i].Split(';'); Console.WriteLine();
            //    for (int j = 0; j < col; j++)
            //    {
            //        table[i, j] = Convert.ToInt32(values[j]); Console.Write(table[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //string[] lines2 = File.ReadAllLines("text.txt");
            //int row2 = lines2.Length; int col2 = lines2[0].Split(';').Length;
            //double[,] table2 = new double[row2, col2];
            //// Заполнение таблицы и вывод на консоль            Console.WriteLine("Второй массив");
            //for (int i = 0; i < row2; i++)
            //{
            //    string[] values2 = lines2[i].Split(';'); Console.WriteLine();
            //    for (int j = 0; j < col2; j++)
            //    {
            //        table2[i, j] = Convert.ToDouble(values2[j].Trim()); Console.Write(table2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //double[,] resultArr = new double[row, col];
            //for (int i = 0; i < row; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        for (int j = 0; j < col; j++)
            //        {
            //            resultArr[i, j] = table[i, j];
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < col; j++)
            //        {
            //            resultArr[i, j] = table2[i, j];
            //        }
            //    }
            //}
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write(resultArr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            Console.WriteLine("Введите размер массива");
            int col=Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int row=Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[col, row];
            for(int i=0; i<col; i++)
            {
                Console.WriteLine();
                for (int j=0; j<row; j++)
                {
                    k++;
                    array[i, j] = k;
                    Console.Write(array[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Введите строчку которую хотите вывести");
            int col2=Convert.ToInt32(Console.ReadLine())-1;
            for(int j = 0; j < row; j++)
            {
                Console.Write(array[col2, j] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Введите столбик который хотите вывести");
            int row2 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine();
            for (int i=0; i < col; i++)
            {
                Console.WriteLine(array[i,row2]+"\t");
            }
            Console.ReadKey();
        }
    }
}
