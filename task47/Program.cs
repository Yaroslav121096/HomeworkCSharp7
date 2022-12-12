void InputMatrix(float[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Random r = new Random();
            matrix[i, j] = r.Next(-10, 10) + r.NextSingle();
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
float[,] matrix = new float[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);