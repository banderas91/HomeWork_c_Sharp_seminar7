/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

Console.Write("Введите количество строк: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите количество столбцов: ");
 int n = Convert.ToInt32(Console.ReadLine());

 int [,] array = new int[ m , n];
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(" массив ====>" );

        
Random ran = new Random();
for (int i = 0; i < m; i++)
{
     for (int j = 0; j < n; j++)
    {
     array[i, j] = ran.Next(1, 15);
     Console.Write( array[i, j]+ " ");
    }
    Console.WriteLine();
}


Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.Write("Среднее арефметическое столбцов ====> ");
double summ = 0;
double ave = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        summ = summ + array[j, i];
        ave = (summ / n);
    }
    
    Console.WriteL( ave + "; ");
}