//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
SquareEvenIndexes(array);
Console.WriteLine("----");
PrintArray(array);


//==============================Методы

//---------------------------Замена элементов с четными i и j на их квадраты
void SquareEvenIndexes(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                inArray[i, j] *= inArray[i, j];
        }
    }
}


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
            if (i % 2 == 0 && j % 2 == 0) Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{inArray[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}




