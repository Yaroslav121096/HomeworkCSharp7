internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите количество строк: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int col = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[row, col];
        double[] result = new double[col];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Random r = new Random();
                matrix[i, j] = new Random().Next(0, 11);
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int j = 0; j < col; j++)
        {
            result[j] = 0;
            for (int i = 0; i < row; i++)
            {
                result[j] += matrix[i, j];

            }
            result[j] /= row;
        }
        Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
        Console.Write(string.Join("\t", result));
    }
}