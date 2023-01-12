// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.



int m = GetUserNumber("Введите число строк массива: ");         // способ задания массива выбран произвольно
int n = GetUserNumber("Введите число столбцов массива: ");

int iMin = 3;
int jMin = 3;
int[,] matrix = GetMatrix(m, n, 0, 10);            // диапазон 0, 10 взят произвольно, для удобства проверки  
PrintArray(matrix);

int [,] result = DeleteCol(matrix, jMin, iMin);
PrintArray(result);



//==================================== Методы ================================

//-----------------Получение числа от пользователя

int GetUserNumber(string messageToUser)
{
    while (true)
    {
        Console.Write(messageToUser);
        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber > 0)
            return userNumber;
        Console.WriteLine("Ошибка! Введите целое число больше нуля");
    }
}



//-----------------Заполнение двумерного массива

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return resultMatrix;
}



//--------------------------Вывод двумерного массива на экран

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



//-------------------------Убираем заданные столбец и строку из матрицы

int[,] DeleteCol(int[,] inArray, int jMin, int iMin)
{
    int[,] resMatr = new int[inArray.GetLength(0), inArray.GetLength(1) - 1];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j<inArray.GetLength(1)-1; j++)
        {
            if (j<jMin)
            resMatr[i,j] = inArray[i,j];
            else 
            resMatr[i,j] = inArray[i,j+1];
        }
    }
    int[,] resMatr1 = new int[resMatr.GetLength(0)-1, resMatr.GetLength(1)];
    for (int j = 0; j < resMatr.GetLength(1); j++)
    {
        for (int i = 0; i < resMatr.GetLength(0)-1; i++)
        {
            if (i<iMin)
            resMatr1[i,j] = resMatr[i,j];
            else 
            resMatr1[i,j] = resMatr[i+1,j];
        }
    }

    return resMatr1;
}