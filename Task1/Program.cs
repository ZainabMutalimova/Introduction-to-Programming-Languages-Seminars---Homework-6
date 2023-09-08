// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите последовательность чисел, разделенных запятой:");
string? line = Console.ReadLine();
string[] delims = new[] { "\n", "\r", ", ", " ", "," };
string[] strings = line.Split(delims, StringSplitOptions.TrimEntries);

var intArray = ConvertStringArrayToIntArray(strings);
Console.WriteLine("Сформирован массив: [" + String.Join(", ", intArray) + "]");
Console.WriteLine($"Количество чисел больше 0 равно {CountOfPositiveNumbers(intArray)}");

int[] ConvertStringArrayToIntArray(string[] stringArray)
{
    int i = 0;
    int[] intArray = new int[] { };
    while (i < stringArray.Length)
    {
        if (int.TryParse(stringArray[i], out var intValue))
            intArray = intArray.Concat(new int[] { intValue }).ToArray();
        i++;
    }
    return intArray;
}
int CountOfPositiveNumbers(int[] intArray)
{
    int count = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}