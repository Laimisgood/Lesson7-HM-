// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
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

void PrintArray(int[,] matrix)
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

void FindIndex(int[,] matrix, int num1, int num2)
{
    if (num1 > matrix.GetLength(0)-1 || num2 > matrix.GetLength(1)-1)
    {
        System.Console.WriteLine("Вы вышли за пределы массива");
    }
    else if (num1 < matrix.GetLength(0) || num2 < matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[num1, num2] == matrix[i, j])
                {
                    System.Console.WriteLine($"в строке {num1} и в столбце {num2} -> число {matrix[num1, num2]}");
                    break;
                    //В некоторых случаях он выводит это сообщение 2 раза, я не знаю почему и как это так происходит
                }
            }
        }

    }
}

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] matrix = CreateMarix(rows, columns);
PrintArray(matrix);
System.Console.WriteLine();
int num1 = Prompt("Введите индекс строки:  ");
int num2 = Prompt("Введите индекс столбца: ");
FindIndex(matrix, num1, num2);
