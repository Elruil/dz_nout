//Задача 23: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N..
int num = GetNum("Введите число таблицу кубов которого хотите получить", "Ошибка ввода данных", "Введите положительное число больше 0");
Console.WriteLine($"Введенное вами число {num}, таблицей кубов которго являются");

for (int i = 1; i <= num; i++)
{
    int result = i*i*i;
    Console.Write($" {result},");
    
}
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
