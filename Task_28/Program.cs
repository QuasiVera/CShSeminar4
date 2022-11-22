// Задача 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
int number = UserInput("Введите целое число: ", "Ошибка ввода!");
Console.WriteLine($"{number} -> {MultN(number)}");




//-----------Ввод данных
int UserInput(string message, string errorMessage)
{    
     while(true)
    {
        Console.Write(message);
        if( int.TryParse(Console.ReadLine(), out int userNumber))

            return userNumber;
        Console.WriteLine(errorMessage);
     } 
}

//------------Умножение

int MultN(int number)
{
     int mult = 1;
     for(int i=1; i <= number; i++)
    
         mult *= i;
    
     return mult;
}
