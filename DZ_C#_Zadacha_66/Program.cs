/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();


Console.WriteLine("\"Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\"");
Console.WriteLine();
int InputNumber(string input)
{
    Console.Write(input);
    int numbers = Convert.ToInt32(Console.ReadLine()!);
    return numbers;
}

void Sum(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($" {summ} ");
        return;
    }
    Sum(m, n - 1, summ);

}
int m = InputNumber("Введи значение \" M \": ");
Console.WriteLine();
int n = InputNumber("Введи значение \" N \": ");
int count = m;

if (m > n)
{
    m = n;
    n = count;
}

Console.WriteLine();
Console.Write($"Сумма натуральных элементов в промежутке от \" {m} \" до \" {n} \" равна: ");
Sum(m, n, count = 0);
