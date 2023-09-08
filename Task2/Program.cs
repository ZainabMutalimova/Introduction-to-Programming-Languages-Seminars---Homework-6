// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Хочешь фокус?");
string? answer = Console.ReadLine().ToLower();

if (answer == "да") GetValues();
else
{
    Console.WriteLine("Зануда!");
    return;
}


void GetValues()
{
    if (answer == "да")
    {
        Console.WriteLine("В таком случае, введите для прямых y = k1 * x + b1, y = k2 * x + b2 значения коэффициентов");
        Console.WriteLine("Введите значение для b1:");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение для k2:");
        int k1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение для b2:");
        int b2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение для k1:");
        int k2 = Convert.ToInt32(Console.ReadLine());
        if (b1 == b2 & k1 == k2)
        {
            Console.WriteLine("Брат, эти прямые совпадают и пересекаются в каждой своей точке, шу-шуть передвинь одну.");
            GetValues();
        }
        else
        {
            int[] xy = GetXY(b1, k1, b2, k2);
            Console.WriteLine($"Точка пересечения прямых y = {k1}x+{b1} и y = {k2}x+{b2}: x = {xy[0]}, y = {xy[1]}.");
        }
    }
}
int[] GetXY(int b1, int k1, int b2, int k2)
{
    int y, x;
    y = (k1 * (b2 - (k2 * (b1 / k1)))) / (k1 - k2);
    x = (y - b1) / k1;
    int[] xy = new int[2] { x, y };
    return xy;
}