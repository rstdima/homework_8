﻿
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n");
int n = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[i, j] = new Random().Next(-10, 10);
      Console.Write(array[i, j] + " ");
   }
   Console.WriteLine();
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      if (number == array[i, j])
      {
         count = 1;
         break;
      }
   }
   // Console.WriteLine();
}

if (count == 0)
{
   Console.WriteLine("такого числа в массиве нет");
}
else
{
   Console.WriteLine("такое число в массиве есть");
}