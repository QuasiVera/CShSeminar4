//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
//диагонали (с индексами (0,0); (1;1) и т.д.  + цвета + c тернаным оператором 
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

int result = SumDiagonalEls(array);
Console.Write($"Сумма элементов по диагонали: {result}");

//=========================Методы

//-------------------------------Сумма элементов по диагонали
// вариант с перебором только тех элементов, которые принадлежат основной диагонали

int SumDiagonalEls(int[,] inArray)
{
    int sum = 0;
    int size = inArray.GetLength(0) < inArray.GetLength(1) ? inArray.GetLength(0) : inArray.GetLength(1);
    for (int i = 0; i < size; i++)
    {                              // границей цикла будет число строк, если их меньше или число стлбцов, если больше их
        sum += inArray[i, i];
    }
    return sum;
}

// int SumDiagonalEls(int[,] inArray)
// {
//     int sum =0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (i == j ) 
//                 sum +=inArray[i, j];
//         }
//     }
//     return sum;
// }

//-------------------------------Получение массива случайных чисел

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


//---------------------------Вывод массива на экран + разметка цветом

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == j) Console.ForegroundColor = ConsoleColor.Green; // есть еще Console.BackgroundColor
            Console.Write($"{inArray[i, j]} ");
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.ResetColor();
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}





