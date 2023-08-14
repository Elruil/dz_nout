//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
int numOne = GetNum("Введите первое число", "Ошибка ввода", "Введите число больше нуля");
int numTwo = GetNum("Введите второе число", "Ошибка ввода", "Введите число больше нуля");
double result = Math.Pow(numOne,numTwo);
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
Console.Write($"первое введенное число {numOne} , второе число {numTwo} , результат возведения числа {numOne} в {numTwo}-ю степень это - {result}");
