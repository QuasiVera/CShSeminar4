// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
Console.Clear();
int size = new Random().Next(3, 5);
int[] array = GetArray(size, -10, 10);
PrintArray(array);
int[] result = PairMultiplication(array);
PrintArray(result);

//--------------Генерируем массив
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
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

//--------------------Умножаем парами
int[] PairMultiplication(int[] array)
{
    int size = 0;
    if(array.Length % 2 == 0)

    {
        size = array.Length / 2;
    }
        
    else
    {
        size = array.Length / 2 + 1;   
    }
    int [] res = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        if(i!=array.Length-1-i)  // Чтобы не умножал сам на себя
            res[i] = array[i]*array[array.Length-1-i];
        else
            res[i] = array[i];
    }
    return res;
}
