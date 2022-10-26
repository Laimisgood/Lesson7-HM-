// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Если ввести квадратную матрицу (2х2, 4x4) то он выводит все значения, но если ввести например матрицу 3х4, то он ругается.
//Я если честно не понял почему он ругается и говорит что выходит за пределы массива

Console.Clear();
int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMarix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void Average(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        double sum = 0.09;
        double avg = 0.0;
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[j, i];
        }
        avg = sum / rows;
        System.Console.Write($"{avg:f1}\t");
    }
}

int rows = Prompt("Введите количество строк для массива: ");
int columns = Prompt("Введите столбцов строк для массива: ");

int[,] matrix = CreateMarix(rows, columns);
PrintMatrix(matrix);
Average(matrix, rows, columns);
System.Console.WriteLine();


//Если ввести квадратную матрицу (2х2, 4x4) то он выводит все значения, но если ввести например матрицу 3х4, то он ругается. 
//Я если честно не понял почему он ругается и говорит что выходит за пределы массива
// Продублировал верхнее сообщение(если вдруг вы не обратили на него внимания)