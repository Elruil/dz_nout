//Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму
//чисел от 1 до А
//4 -> 10 (1+2+3+4=10)
//7 -> 28
//8 -> 36
Console.Clear();
int num = GetNumberFromUser("Введите целое число А", "Ошибка ввода");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");
int GetSumNumbers(int number)
{
    int sum = 0;
        while(number > 0)
        {
            sum += number;
            number--;
        }
        return sum;
}
int GetNumberFromUser(string Message, string errorMessage)
{
    while (true)
    {
        Console.Write(Message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}