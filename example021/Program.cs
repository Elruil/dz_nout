//Задача 21: Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.
int xOne = GetNum("Введите число для обозначения координаты по оси Х первого числа", "Ошибка ввода данных");
int yOne = GetNum("Введите число для обозначения координаты по оси Y первого числа", "Ошибка ввода данных");
int zOne = GetNum("Введиет число для обозначения координаты по оси Z первого числа", "Ошибка ввода данных");
int xTwo = GetNum("Введите число для обозначения координаты по оси Х второго числа", "Ошибка ввода данных");
int yTwo = GetNum("Введите число для обозначения координаты по оси Y второго числа", "Ошибка ввода данных");
int zTwo = GetNum("Введите число для обозначения координаты по оси Z первого числа", "Ошибка ввода данных");
double Delay = Distance( xOne,  xTwo,  yOne,  yTwo,  zOne,  zTwo);
Console.WriteLine($"Расстояние между указанными точками равно  {Delay}");
static double Distance (int x1, int x2, int y1, int y2, int z1, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    return Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
}
static int GetNum(string Message, string errorMessage)
{
    while (true)
    {
        try
        {
            Console.WriteLine(Message);
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");
        }
    }
}
