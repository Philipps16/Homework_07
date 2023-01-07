void InputMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 101);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ReleaseArray (int [,] matrix)
{
    {
        for (int i = 0; i < matrix.GetLength(0) / 2; i++)
        {   
            int b = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                b = matrix[i,j];
                matrix[i,j] = matrix [(matrix.GetLength(0) - 1 - i), j];
                matrix [(matrix.GetLength(0) - i - 1), j] = b;
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
        for (int i = matrix.GetLength(0) / 2; i < matrix.GetLength(0); i++)
        {   
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} \t");
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
Console.WriteLine ("Итоговый массив: ");
ReleaseArray(matrix);
