// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов
// массива, значения которых лежат в отрезке [10,99]

Console.Clear();
int[] array = GetArray(123, -200, 200);
PrintArray(array);
Console.WriteLine(String.Join(" ", array));
int countPositiveEl = CountPositiveEl(array, 10, 99);


Console.WriteLine($"Count of positive = {countPositiveEl} ");
//////////////////////////////////////////////////////////////////////////////////
// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}
// Возвращает число положительных чисел массива arr
int CountPositiveEl(int[] arr, int min, int max)
{
    int countPositiveEl = 0;
    foreach (int el in arr)
    {
        if (el >= min && el<=max) countPositiveEl += 1;
    }
    return countPositiveEl;
}

//-----------Печатает массив
void PrintArray(int[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write($"]");
}
