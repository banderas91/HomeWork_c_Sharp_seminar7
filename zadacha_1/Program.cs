/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными (тип double) числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
Console.Write("Введите количество строк: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите количество столбцов: ");
 int n = Convert.ToInt32(Console.ReadLine());

 double [,] array = new double[ m , n];
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(" массив ====>" );


// Объявляем двумерный массив
        
            Random ran = new Random();
      // Инициализируем данный массив
         for (int i = 0; i < m; i++)
         {
            for (int j = 0; j < n; j++)
            {
               array[i, j] = ran.NextDouble() + ran.Next(1, 15);
               Console.Write("{0,6:F2}", array[i, j]);
            }
           Console.WriteLine();
         }