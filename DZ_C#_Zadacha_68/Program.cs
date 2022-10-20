/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.Clear();
Console.WriteLine();
Console.WriteLine("\"Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.\"");
Console.WriteLine();
int m = InputNumber("Введи значение \" M \": ");
int n = InputNumber("Введи значение \" N \": ");
Console.WriteLine();
int MyAkkerman = Akkerman(m, n);
Console.Write($"Функция Аккермана для \"{m}\" и \"{n}\" =   {MyAkkerman} ");
Console.WriteLine();

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine()!);
    return output;
}

int Akkerman(int m, int n)

{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
Console.WriteLine();

    

