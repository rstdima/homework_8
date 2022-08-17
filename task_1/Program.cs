// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.WriteLine("Введите число строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
{
   for (int j = 0; j < n; j++)
   {
      array[i, j] = new Random().Next(-10, 10) + rand.NextDouble();
      // Console.WriteLine($"Abs({array}) = {Math.Abs(array[i, j])}"); 
       Console.Write(Math.Round(array[i, j], 1) + " ");  // 1 -один знак после запятой
   }
   Console.WriteLine("");
}
