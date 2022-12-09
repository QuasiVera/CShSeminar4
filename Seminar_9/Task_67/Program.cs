// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр

int n = UserInput("Введите целое число  m: ", "Ошибка!");

int sum = SumDigits(n);
Console.WriteLine($"{n} - > {sum}");


//============================Методы=====================

//---------------Нахождение суммы цифр числа
int SumDigits(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumDigits(n / 10);
}


//-----------Ввод данных
int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if ((int.TryParse(Console.ReadLine(), out int userNumber)) && userNumber > 0)

            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

