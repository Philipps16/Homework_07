void InputMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ReleaseArray (int [,] matrix)
{
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i,j];     
            }
        Console.WriteLine ($"Сумма {j + 1} столбца равна: {Math.Round ((sum/(matrix.GetLength(0))), 1)}");
        }
       
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];
Console.WriteLine ("Начальный массив: ");
InputMatrix(matrix);
ReleaseArray(matrix);