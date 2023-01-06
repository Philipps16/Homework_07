void InputMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ReleaseArray (int [,] matrix, int a, int b)
{
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
            {
                Console.Write ("Данной позиции нет");
                return;
            }
            else
            {
                Console.Write ($"Значение данной позиции: {matrix[a, b]}");
                return;
            }

        }
        Console.WriteLine();
    }
}
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];
Console.WriteLine ("Начальный массив: ");
InputMatrix(matrix);
Console.Write("Введите позицию строки: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int b = Convert.ToInt32 (Console.ReadLine());
ReleaseArray(matrix, a, b);