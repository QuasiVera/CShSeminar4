// Задача 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int start = UserInput("Введите целое число  m: ", "Ошибка!");
int n = UserInput("Введите целое число n: ", "Ошибка!");


string result  = Numbers(start, n);

Console.WriteLine(result);



//============================Методы=====================
 //-----------Ввод данных
int UserInput(string message, string errorMessage)
{    
     while(true)
    {
        Console.Write(message);
        if( (int.TryParse(Console.ReadLine(), out int userNumber))&& userNumber>0)

            return userNumber;
        Console.WriteLine(errorMessage);
     } 
}



//-------------Вывод чисел рекурсией
string Numbers(int start, int n)
{
    if (start<n)
    {
    if (start==n)
        return start.ToString();

    return start + " " + Numbers(start + 1, n);
    }
    else
    {
        if (start==n)
        return start.ToString();

    return start + " " + Numbers(start - 1, n);
    }
}
