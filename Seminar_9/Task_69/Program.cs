// Задача 69. Напишите программу, которая на вход принимает два числа A и B, и возводит число
// А в целую степень B с помощью рекурсии.

int a = UserInput("Введите целое число  A: ", "Ошибка!");
int b = UserInput("Введите целое число  B: ", "Ошибка!");


int result = Pow(a, b);
Console.WriteLine($"{a} в степени {b} = {result}");


//============================Методы=====================

//-----------Ввод данных
int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if ((int.TryParse(Console.ReadLine(), out int userNumber)) && userNumber >= 0)

            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


//-----------------Возведение в степень рекурсией
int Pow(int a, int b)
{
    if (b == 0) return 1;
    if (b == 1) return a;
    return a * Pow(a, b - 1);
}