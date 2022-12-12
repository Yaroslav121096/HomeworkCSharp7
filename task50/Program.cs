Console.Clear();
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, col];
Console.Write("Введите позицию элемента по строке: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента по столбцу: ");
int colPosition = Convert.ToInt32(Console.ReadLine());
colPosition--;
rowPosition--;
if (row >= rowPosition && col >= colPosition)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"На сторке {rowPosition + 1} в столбце {colPosition + 1} находится число: {matrix[rowPosition, colPosition]}");
}
else
    Console.WriteLine("Такой позиции нет");