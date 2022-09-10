/*Задача 50. Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

Console.Write("Введите количество строк: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите количество столбцов: ");
 int n = Convert.ToInt32(Console.ReadLine());

 double [,] array = new double[ m , n];
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(" массив ====>" );

        
Random ran = new Random();
for (int i = 0; i < m; i++)
{
     for (int j = 0; j < n; j++)
    {
     array[i, j] = ran.NextDouble() + ran.Next(1, 15);
     Console.Write("{0,6:F2}", array[i, j]);
    }
    Console.WriteLine();
}
Console.BackgroundColor = ConsoleColor.Green;
Console.Write("Введите позицию элемента в строке: ");
int lin = Convert.ToInt32(Console.ReadLine());
Console.BackgroundColor = ConsoleColor.Green;
Console.Write("Введите позцию элемента в столбце: ");
int collumn = Convert.ToInt32(Console.ReadLine());
if (lin >= array.GetLength(0) || collumn >= array.GetLength(1))
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.Write("Такого элемента нет");
}
else
{
Console.Write("{0,6:F2}", array[lin, collumn]);
}
