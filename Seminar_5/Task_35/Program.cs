// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов
// массива, значения которых лежат в отрезке [10,99]

Console.Clear();
int[] array = GetArray(123, -200, 200);

Console.WriteLine(String.Join(" ", array));
int counElements = CountElements(array, 10, 99);

Console.WriteLine($"Count elements [10; 99] = {counElements} ");

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
// Возвращает число элементов массива arr, входящих в отрезок [min, max] 
int CountElements(int[] arr, int min, int max)
{
    int counElements = 0;
    foreach (int el in arr)
    {
        if (el >= min && el<=max) counElements += 1;
    }
    return counElements;
}

