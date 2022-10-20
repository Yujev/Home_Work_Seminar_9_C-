/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии. 

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();
Console.WriteLine();
Console.Write("Введи число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

string Recurs(int minValue, int n)
{
    if (minValue == n)
    {
        return n.ToString();
    }
    return (Recurs(minValue + 1, n) + " " + minValue);
}
Console.WriteLine($"Натуральные числа в промежутке от N до 1 -> " + "   "  + Recurs(1, n));
Console.WriteLine();