// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
void Main()
{
    System.Console.Write("Введите неотрицательное число M : ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите неотрицательное число N : ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < 0 || n < 0)
        System.Console.Write("Введены некорректные данные ! ");
    else
        System.Console.WriteLine("Результат: " + Ackermann(m, n));
}
int Ackermann(int a, int b)
{
    if (a == 0)
        return b + 1;
    else if (b == 0 && a > 0)
        return Ackermann(a - 1, 1);
    else
        return Ackermann(a - 1, Ackermann(a, b - 1));
}

Main();
