//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
int number = GetNum("Введите число, сумму чисел которого вы хотите узнать", "Ошибка ввода", "Введите число больше нуля");
int summ = GetSumNumbers(number);
static int GetNum(string Message, string errorMessage, string ErrorEnter)
{
    while (true)
    {
        try
        {
            Console.WriteLine(Message);
            int num = int.Parse(Console.ReadLine() ?? "");
            if (num > 0)
                return num;
            else Console.WriteLine(ErrorEnter);
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");
        }
    }
}
int GetSumNumbers(int number)
{   int sum = 0;
    while (number > 0)

    {
        int a = number % 10;
        int b = number / 10;
        sum = +a;
    }
    return sum;
}
Console.WriteLine($"{number}    {summ}");
