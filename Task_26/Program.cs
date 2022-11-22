// Задача 26 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
int number = UserInput("Введите целое число: ", "Ошибка ввода!");
Console.WriteLine($"{number} -> {countN(number)}");

//-------------------Methods

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

//-------------Число цифр

int countN(int number)
{
    int i=0;
    do
    {
        i++;
        number = number/10;
    }
    while(number!=0);
    return i;
}
